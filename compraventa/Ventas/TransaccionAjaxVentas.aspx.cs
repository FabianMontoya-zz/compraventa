using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using compraventa.VentasCredito;

namespace compraventa.Ventas
{
    public partial class TransaccionAjaxVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("../Login/Index.aspx#postback", false);
            }
            else
            {
                string action = Request.Form["status"];
                switch (action)
                {
                    case "Venta":
                        InsertarVenta();
                        break;
                }
            }
        }

        public void InsertarVenta()
        {
            VentasCreditoClass Datos = new VentasCreditoClass();
            VentasCreditoSQLClass SQL = new VentasCreditoSQLClass();
            string Result = "";
            Datos.Persona = Request.Form["persona"];
            Datos.Usuario = Session["ID_usuario"].ToString();
            Datos.Valor = Request.Form["Valor"];
            Datos.ID_Inventario = Request.Form["articulo"];
            try
            {
                SQL.InsertVenta(Datos);
                SQL.InsertDetalleVentas(Datos);
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