using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compraventa.VentasCredito
{
    public class TipoAbonoClass
    {
        private string _Id_Tipo;
        private string _Tipo;

        public string Id_Tipo
        {
            get { return _Id_Tipo; }
            set { _Id_Tipo = value; }
        }

        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }
    }
}