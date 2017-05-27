using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace compraventa.Factura
{
    public partial class About : System.Web.UI.Page
    {
        conexion c = new conexion();

        MySqlCommand sql;
        MySqlDataReader r;
        MySqlDataAdapter mdaDatos;
        DataTable dt = new DataTable();



        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int emp_persona;
            emp_persona = Convert.ToInt32(TextBox1.Text);
            string cmd = "SELECT emp_id as ID_empeno, emp_valor as Valor_total_del_empeno, emp_valor_abonos as Total_abonos, emp_valor_retiro as Total_retiro, emp_fecha_ingreso as Fecha_de_empeno from empeno where emp_persona = " + emp_persona + ";";
            sql = new MySqlCommand(cmd, c.abrir_conexion());

            mdaDatos = new MySqlDataAdapter(sql);
            mdaDatos.Fill(dt);

            c.cerrar_conexion();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(TextBox2.Text);

            List<string> datos = new List<string>();

            string cmd = "SELECT emp_persona, emp_usuario, emp_fecha_ingreso, emp_fecha_retiro, emp_valor, emp_valor_abonos, emp_valor_retiro, emp_fecha_grabado from empeno where emp_id = " + id + ";";
            sql = new MySqlCommand(cmd, c.abrir_conexion());

            try
            {
                r = sql.ExecuteReader();
                while (r.Read())
                {
                    datos.Add(Convert.ToString(r["emp_persona"]));
                    datos.Add(Convert.ToString(r["emp_usuario"]));
                    datos.Add(Convert.ToString(r["emp_fecha_ingreso"]));
                    datos.Add(Convert.ToString(r["emp_fecha_retiro"]));
                    datos.Add(Convert.ToString(r["emp_valor"]));
                    datos.Add(Convert.ToString(r["emp_valor_abonos"]));
                    datos.Add(Convert.ToString(r["emp_valor_retiro"]));
                    datos.Add(Convert.ToString(r["emp_fecha_grabado"]));

                    //MessageBox.Show("Persona  " + datos[0] + Environment.NewLine + "Usuario  " + datos[1] + Environment.NewLine + "Fecha de ingreso  " + datos[2] + Environment.NewLine + "fecha_retiro  " + datos[3] + Environment.NewLine + "Valor  " + datos[4] + Environment.NewLine +  "fecha_grabado  " + datos[7]);

                }
                c.cerrar_conexion();

                Session.Add("empeño", id);
                Server.Transfer("Factura.aspx");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


        }

    }
}