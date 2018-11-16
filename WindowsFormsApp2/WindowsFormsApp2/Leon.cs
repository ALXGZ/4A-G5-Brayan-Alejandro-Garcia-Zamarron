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

        public int Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public string Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }

        public string Salud
        {
            get { return this.salud; }
            set { this.salud = value; }
        }

        public double Estatura
        {
            get { return this.estatura; }
            set { this.estatura = value; }
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

        public void Cazar()
        {
            Console.WriteLine("Esta canzando");
        }

        public void Dormir()
        {
            Console.WriteLine("Esta dormido");
        }

        public void Trepar()
        {
            Console.WriteLine("Esta trepando");
        }

        public void Procrear()
        {
            Console.WriteLine("Esta reproduciendoce");
        }

        public void Respirar()
        {
            Console.WriteLine("Esta repirando");
        }
    }
}
