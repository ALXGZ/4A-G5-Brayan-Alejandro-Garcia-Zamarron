using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Persona
    {
        string nombre = "", apellido = "";
        int edad = 0;
        double peso = 0.0, estatura = 0.0;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public double Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }

        public double Estatura
        {
            get { return this.estatura; }
            set { this.estatura = value; }
        }

        public Persona()
        {

        }

        public Persona(string nombre, string apellidos, string sexo, string fechNac, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = 0;
            this.peso = 0.0;
            this.estatura = 0.0;
        }

        public void Cantar()
        {
            Console.WriteLine("Estoy cantando");
        }

        public void Respirar()
        {
            Console.WriteLine("Estoy respirando");
        }

        public void Saltar()
        {
            Console.WriteLine("Estoy respirando");
        }

        public void Caminar()
        {
            Console.WriteLine("Estoy caminando");
        }

        public void Escribir()
        {
            Console.WriteLine("Estoy escribiendo");
        }
    }
}
