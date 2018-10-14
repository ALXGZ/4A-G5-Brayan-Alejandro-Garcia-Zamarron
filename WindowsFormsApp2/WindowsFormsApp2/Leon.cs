using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class leon
    {
        public string Sexo = "", salud = "";
        public double estatura = 0.0;
        public int edad = 0, peso = 0;

        public string Cazar
        {
            get { return this.Cazar; }
            set { this.Cazar = value; }
        }

        public string Dormir
        {
            get { return this.Dormir; }
            set { this.Dormir = value; }
        }

        public string Respirar
        {
            get { return this.Respirar; }
            set { this.Respirar = value; }
        }

        public string Trepar
        {
            get { return this.Trepar; }
            set { this.Trepar = value; }
        }

        public string Reproducirse
        {
            get { return this.Reproducirse; }
            set { this.Reproducirse = value; }
        }

        public leon()
        {

        }

        public leon(string especie, string tamaño, string sexo, string color, double peso)
        {
            this.Sexo = Sexo;
            this.salud = salud;
            this.edad = edad;
            this.estatura = estatura ;
        }
    }
}
