using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Leon
    {
        int peso = 0, edad = 0;
        string sexo = "", salud = "";
        double estatura = 0.0;

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

        public Leon()
        {

        }

        public Leon(int peso, int edad, string sexo, string salud, double estatura)
        {
            this.peso = peso;
            this.edad = edad;
            this.sexo = sexo;
            this.salud = salud;
            this.estatura = estatura;
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
