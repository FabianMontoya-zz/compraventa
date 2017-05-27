using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compraventa.Login
{
    public partial class LoginTransaccionAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Request.Form["status"];
            switch (action)
            {
                case "Login":
                    Ingresar();
                    break;

            }
        }

        private void Ingresar()
        {
            string result = "";
            LoginSQLClass sql = new LoginSQLClass();
            sql.User = Request.Form["user"];
            sql.Password = Request.Form["pass"];
            sql = sql.ConsultarUsuario(sql);
            if (sql.Count != "0")
            {
                Session["usuario"] = Request.Form["user"];
                Session["ID_usuario"] = sql.ID;
                Response.Write(result);
            }
            else
            {
                Response.Write(result);
            }
        }
    }
}