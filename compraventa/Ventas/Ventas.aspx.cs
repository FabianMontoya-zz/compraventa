using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compraventa.VentasCredito
{
    public partial class Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                //Si no hay sesión redirigimos al login
                Response.Redirect("../Login/Index.aspx#postback", false);
            }
        }
    }
}