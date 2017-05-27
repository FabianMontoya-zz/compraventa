using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace compraventa.Login
{
    public class LoginSQLClass
    {
        private string _User;
        private string _Password;
        private string _ID;
        private string _Count;


        public MySqlConnection conn;
        public string myConnectionString = "Server=localhost;user id=root;password=;Database=compraventa";

        public string User
        {
            get { return _User; }
            set { _User = value; }
        }

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        public LoginSQLClass ConsultarUsuario(LoginSQLClass Usuario)
        {
            string sql = "SELECT DISTINCT(usu_id), usu_id FROM USUARIO WHERE usu_persona = '" + Usuario.User + "' AND usu_password = '" + Usuario.Password + "'";

            LoginSQLClass Login = new LoginSQLClass();
            conn = new MySqlConnection(myConnectionString);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
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
                                Login.Count = reader.GetValue(0).ToString();
                                Login.ID = reader.GetValue(1).ToString();
                            }
                        }
                        else
                        {
                            Login.Count = "0";
                        }
                        conn.Close();
                    }
                }
            }
            
            return Login;
        }

    }
}