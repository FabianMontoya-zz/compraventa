using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace compraventa.VentasCredito
{
    public partial class TransaccionAjaxVentasCredito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("../Login/Index.aspx", false);
            }
            else
            {
                string action = Request.Form["status"];
                switch (action)
                {
                    case "Personas":
                        CargarPersonas();
                        break;
                    case "Tipos":
                        CargarTipo();
                        break;
                    case "Articulos":
                        CargarArticulos();
                        break;
                    case "VentaCredito":
                        InsertarVenta();
                        break;
                }
            }
        }

        public void CargarPersonas()
        {
            List<PersonaClass> ListClass = new List<PersonaClass>();
            VentasCreditoSQLClass SQL = new VentasCreditoSQLClass();
            ListClass = SQL.ConsultarAllPersonas();
            Response.Write(JsonConvert.SerializeObject(ListClass.ToArray()));
        }

        public void CargarTipo()
        {
            List<TipoAbonoClass> ListClass = new List<TipoAbonoClass>();
            VentasCreditoSQLClass SQL = new VentasCreditoSQLClass();
            ListClass = SQL.ConsultarAllTiposAbono();
            Response.Write(JsonConvert.SerializeObject(ListClass.ToArray()));
        }

        public void CargarArticulos()
        {
            List<ArticuloClass> ListClass = new List<ArticuloClass>();
            VentasCreditoSQLClass SQL = new VentasCreditoSQLClass();
            ListClass = SQL.ConsultarAllArticulos();
            Response.Write(JsonConvert.SerializeObject(ListClass.ToArray()));
        }

        public void InsertarVenta()
        {
            VentasCreditoClass Datos = new VentasCreditoClass();
            VentasCreditoSQLClass SQL = new VentasCreditoSQLClass();
            string Result = "";
            Datos.Persona = Request.Form["persona"];
            Datos.Usuario = Session["ID_usuario"].ToString();
            Datos.FechaFin = Request.Form["fecha_Fin"];
            Datos.Valor = Request.Form["Valor"];
            Datos.ID_Inventario = Request.Form["articulo"];
            Datos.ValorAbono = Request.Form["Abono"];
            try
            {
                SQL.InsertVentaCredito(Datos);
                SQL.InsertDetalleCredito(Datos);
                Result = "Exito";
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                Result = "Error";
            }
            Response.Write(Result);
        }
    }
}