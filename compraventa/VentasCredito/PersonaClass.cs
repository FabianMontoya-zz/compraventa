using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compraventa.VentasCredito
{
    public class PersonaClass
    {
        private string _Index;
        private string _cedula;
        private string _primer_nombre;
        private string _segundo_nombre;
        private string _primer_apellido;
        private string _segundo_apellido;
        private string _genero;
        private string _fecha_nacimiento;
        private string _tipo;

        public string Index
        {
            get { return _Index; }
            set { _Index = value; }
        }
        public string cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }
        public string primer_nombre
        {
            get { return _primer_nombre; }
            set { _primer_nombre = value; }
        }
        public string segundo_nombre
        {
            get { return _segundo_nombre; }
            set { _segundo_nombre = value; }
        }
        public string primer_apellido
        {
            get { return _primer_apellido; }
            set { _primer_apellido = value; }
        }
        public string segundo_apellido
        {
            get { return _segundo_apellido; }
            set { _segundo_apellido = value; }
        }
        public string genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
        public string fecha_nacimiento
        {
            get { return _fecha_nacimiento; }
            set { _fecha_nacimiento = value; }
        }
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }
}