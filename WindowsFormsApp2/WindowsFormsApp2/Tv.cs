using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class tv
    {
        public string forma = "", color = "", tamaño = "", modelo = "";
        public double costo = 0.0;

        public string Ver_vi
        {
            get { return this.Ver_vi; }
            set { this.Ver_vi = value; }
        }

        public string Ver_inf
        {
            get { return this.Ver_inf; }
            set { this.Ver_inf = value; }
        }

        public string Red
        {
            get { return this.Red; }
            set { this.Red = value; }
        }

        public string Musica
        {
            get { return this.Musica; }
            set { this.Musica = value; }
        }

        public string Vidjuegos
        {
            get { return this.Vidjuegos; }
            set { this.Vidjuegos = value; }
        }

        public tv()
        {

        }

        public tv(string calidad, string modelo, string forma, string video, double tamaño)
        {
            this.forma = forma;
            this.color = color;
            this.modelo = modelo;
            this.costo = costo;
        }
    }
}
