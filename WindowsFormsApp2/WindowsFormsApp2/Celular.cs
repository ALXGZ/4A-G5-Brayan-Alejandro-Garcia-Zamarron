using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class celular
    {
        public string forma = "", color = "", modelo = "", material = "", tamaño = "";

        public string Comunicacion
        {
            get { return this.Comunicacion; }
            set { this.Comunicacion = value; }
        }

        public string Ver_vi
        {
            get { return this.Ver_vi; }
            set { this.Ver_vi = value; }
        }

        public string Red
        {
            get { return this.Red; }
            set { this.Red = value; }
        }

        public string Calcular
        {
            get { return this.Calcular; }
            set { this.Calcular = value; }
        }

        public string Tomar_fo
        {
            get { return this.Tomar_fo; }
            set { this.Tomar_fo = value; }
        }

        public celular()
        {

        }

        public celular(string tamaño, string velocidad, string comodo, string resistencia, double almacenamiento)
        {
            this.forma = forma;
            this.color = color;
            this.modelo = modelo;
            this.material = material;
            this.tamaño = tamaño;
        }
    }
}
