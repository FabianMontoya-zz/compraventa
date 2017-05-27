using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compraventa.VentasCredito
{
    public class ArticuloClass
    {
        private string _ID_Inventario;
        private string _ID_Articulo;
        private string _Art_Nombre;
        private string _Art_Precio;

        public string ID_Inventario
        {
            get { return _ID_Inventario; }
            set { _ID_Inventario = value; }
        }

        public string ID_Articulo
        {
            get { return _ID_Articulo; }
            set { _ID_Articulo = value; }
        }

        public string Art_Nombre
        {
            get { return _Art_Nombre; }
            set { _Art_Nombre = value; }
        }

        public string Art_Precio
        {
            get { return _Art_Precio; }
            set { _Art_Precio = value; }
        }
    }
}