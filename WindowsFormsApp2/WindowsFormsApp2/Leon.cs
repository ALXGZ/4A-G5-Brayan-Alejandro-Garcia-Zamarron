using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class leon
    {
        public int peso = 0, edad = 0;
        public string sexo = "", salud = "";
        public double estatura = 0.0;

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

        public string Procrear
        {
            get { return this.Procrear; }
            set { this.Procrear = value; }
        }

        public leon()
        {

        }

        public leon(string especie, string tamaño, string sexo, string color, double peso)
        {
            this.peso = 0;
            this.edad = 0;
            this.sexo = sexo;
            this.salud = salud;
            this.estatura = 0.0;
        }
    }
}
