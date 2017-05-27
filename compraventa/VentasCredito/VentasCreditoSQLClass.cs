using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace compraventa.VentasCredito
{
    public class VentasCreditoSQLClass
    {
        public MySqlConnection conn;
        public string myConnectionString = "Server=localhost;user id=root;password=;Database=compraventa";

        public List<PersonaClass> ConsultarAllPersonas()
        {
            List<PersonaClass> List = new List<PersonaClass>();
            conn = new MySqlConnection(myConnectionString);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();

            string sql = " SELECT " +
                         " IFNULL(PER_CEDULA, '') AS Cedula, " +
                         " IFNULL(PER_PRIMER_NOMBRE, '') AS PrimerNombre, " +
                         " IFNULL(PER_SEGUNDO_NOMBRE, '') AS SegundoNombre, " +
                         " IFNULL(PER_PRIMER_APELLIDO, '') AS PrimerApellido, " +
                         " IFNULL(PER_SEGUNDO_APELLIDO, '') AS SegundoApellido, " +
                         " IFNULL(PER_GENERO, '') AS Genero, " +
                         " IFNULL(PER_FECHA_NACIMIENTO, '') AS FechaNacimiento, " +
                         " IFNULL(PER_TIPO, '') AS Tipo " +
                         " FROM PERSONA " +
                         " WHERE PER_TIPO = 'C'";
            try
            {
                using (conn)
                {
                    using (cmd)
                    {
                        using (MyAdapter)
                        {
                            MySqlDataReader reader;
                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;
                            MyAdapter.SelectCommand = cmd;
                            conn.Open();
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    PersonaClass persona = new PersonaClass();
                                    persona.cedula = reader.GetValue(0).ToString();
                                    persona.primer_nombre = reader.GetValue(1).ToString();
                                    persona.segundo_nombre = reader.GetValue(2).ToString();
                                    persona.primer_apellido = reader.GetValue(3).ToString();
                                    persona.segundo_apellido = reader.GetValue(4).ToString();
                                    persona.genero = reader.GetValue(5).ToString();
                                    persona.fecha_nacimiento = reader.GetValue(6).ToString();
                                    persona.tipo = reader.GetValue(7).ToString();
                                    List.Add(persona);
                                }
                            }
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }
            return List;
        }

        public List<TipoAbonoClass> ConsultarAllTiposAbono()
        {
            List<TipoAbonoClass> List = new List<TipoAbonoClass>();
            conn = new MySqlConnection(myConnectionString);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();

            string sql = " SELECT " +
                         " TAB_ID, " +
                         " TAB_Nombre " +
                         " FROM TIPO_ABONO ";
            try
            {
                using (conn)
                {
                    using (cmd)
                    {
                        using (MyAdapter)
                        {
                            MySqlDataReader reader;
                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;
                            MyAdapter.SelectCommand = cmd;
                            conn.Open();
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    TipoAbonoClass Tipo = new TipoAbonoClass();
                                    Tipo.Id_Tipo = reader.GetValue(0).ToString();
                                    Tipo.Tipo = reader.GetValue(1).ToString();
                                    List.Add(Tipo);
                                }
                            }
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }
            return List;
        }
        public List<ArticuloClass> ConsultarAllArticulos()
        {
            List<ArticuloClass> List = new List<ArticuloClass>();
            conn = new MySqlConnection(myConnectionString);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();

            string sql = " SELECT " +
                         " INV.INV_ID, " +
                         " INV.INV_ARTICULO_EMPENADO, " +
                         " AR.ART_NOMBRE, " +
                         " INV.INV_VALOR " +
                         " FROM INVENTARIO INV " +
                         " INNER JOIN ARTICULO_EMPENADO AREM ON AREM.AME_ID = INV.INV_ARTICULO_EMPENADO " +
                         " INNER JOIN ARTICULO AR ON AR.ART_ID = AREM.AEM_ARTICULO " +
                         " ORDER BY INV.INV_ID ";
            try
            {
                using (conn)
                {
                    using (cmd)
                    {
                        using (MyAdapter)
                        {
                            MySqlDataReader reader;
                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;
                            MyAdapter.SelectCommand = cmd;
                            conn.Open();
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    ArticuloClass art = new ArticuloClass();
                                    art.ID_Inventario = reader.GetValue(0).ToString();
                                    art.ID_Articulo = reader.GetValue(1).ToString();
                                    art.Art_Nombre = reader.GetValue(2).ToString();
                                    art.Art_Precio = reader.GetValue(3).ToString();
                                    List.Add(art);
                                }
                            }
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }
            return List;
        }

        public string InsertVentaCredito(VentasCreditoClass datos)
        {
            string result = "";
            conn = new MySqlConnection(myConnectionString);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();

            string sql = " INSERT INTO " +
                         " CREDITO ( " +
                         " CRE_PERSONA, CRE_USUARIO, " +
                         " CRE_FECHA_INICIO, " +
                         " CRE_FECHA_FIN, " +
                         " CRE_VALOR, " +
                         " CRE_VALOR_ABONOS, " +
                         " CRE_VALOR_RETIRO " +
                         " ) VALUES ( " +
                         " " + datos.Persona + ", " + datos.Usuario + ", NOW(), '" + datos.FechaFin + "', " + datos.Valor + ", " +
                         " " + datos.ValorAbono + ", " + datos.Valor + ") ";
            try
            {
                using (conn)
                {
                    using (cmd)
                    {
                        using (MyAdapter)
                        {
                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;
                            MyAdapter.SelectCommand = cmd;
                            conn.Open();
                            cmd.ExecuteNonQuery();

                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public string InsertDetalleCredito(VentasCreditoClass datos)
        {
            string result = "";
            conn = new MySqlConnection(myConnectionString);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();

            string idCre = "SELECT MAX(CRE_ID) FROM CREDITO ";
            string ID = "";
            try
            {
                using (conn)
                {
                    using (cmd)
                    {
                        using (MyAdapter)
                        {
                            MySqlDataReader reader;
                            cmd.CommandText = idCre;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;
                            MyAdapter.SelectCommand = cmd;
                            conn.Open();
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                ID = reader.GetValue(0).ToString();
                            }
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }


            string sql = " INSERT INTO " +
                         " DETALLE_CREDITO ( " +
                         " dve_inventario, " +
                         " dve_credito " +
                         " ) VALUES ( " +
                         " " + datos.ID_Inventario + ", " + ID + ") ";

            try
            {
                using (conn)
                {
                    using (cmd)
                    {
                        using (MyAdapter)
                        {
                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;
                            MyAdapter.SelectCommand = cmd;
                            conn.Open();
                            cmd.ExecuteNonQuery();

                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }

            return result;
        }



        public string InsertVenta(VentasCreditoClass datos)
        {
            string result = "";
            conn = new MySqlConnection(myConnectionString);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();

            string sql = " INSERT INTO " +
                         " venta ( " +
                         " ven_persona, ven_usuario, " +
                         " ven_fecha, " +
                         " ven_valor " +
                         " ) VALUES ( " +
                         " " + datos.Persona + ", " + datos.Usuario + ", NOW(), " + datos.Valor + ") ";
            try
            {
                using (conn)
                {
                    using (cmd)
                    {
                        using (MyAdapter)
                        {
                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;
                            MyAdapter.SelectCommand = cmd;
                            conn.Open();
                            cmd.ExecuteNonQuery();

                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public string InsertDetalleVentas(VentasCreditoClass datos)
        {
            string result = "";
            conn = new MySqlConnection(myConnectionString);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();

            string idCre = " SELECT MAX(ven_id) FROM VENTA ";
            string ID = "";
            try
            {
                using (conn)
                {
                    using (cmd)
                    {
                        using (MyAdapter)
                        {
                            MySqlDataReader reader;
                            cmd.CommandText = idCre;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;
                            MyAdapter.SelectCommand = cmd;
                            conn.Open();
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                ID = reader.GetValue(0).ToString();
                            }
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }


            string sql = " INSERT INTO " +
                         " DETALLE_VENTA ( " +
                         " dve_inventario, " +
                         " dve_venta " +
                         " ) VALUES ( " +
                         " " + datos.ID_Inventario + ", " + ID + ") ";

            try
            {
                using (conn)
                {
                    using (cmd)
                    {
                        using (MyAdapter)
                        {
                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;
                            MyAdapter.SelectCommand = cmd;
                            conn.Open();
                            cmd.ExecuteNonQuery();

                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
    }
}