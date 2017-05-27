using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace compraventa
{
    public class conexion
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=compraventa; Uid=root; pwd=;");

        public MySqlConnection abrir_conexion()
        {
            try
            {
                con.Open();
            }
            catch (MySqlException e)
            {
                //MessageBox.Show(e.Message);
            }
            return con;
        }

        public void cerrar_conexion()
        {
            try
            {
                con.Close();

            }
            catch (MySqlException e)
            {

            }
        }

    }
}
