using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compraventa.VentasCredito
{
    public class VentasCreditoClass
    {
        private string _Persona;
        private string _Usuario;
        private string _FechaFin;
        private string _Valor;
        private string _ID_Inventario;
        private string _ValorAbono;
        public string Persona
        {
            get { return _Persona; }
            set { _Persona = value; }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public string FechaFin
        {
            get { return _FechaFin; }
            set { _FechaFin = value; }
        }

        public string Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        public string ValorAbono
        {
            get { return _ValorAbono; }
            set { _ValorAbono = value; }
        }

        public string ID_Inventario
        {
            get { return _ID_Inventario; }
            set { _ID_Inventario = value; }
        }
    }
}