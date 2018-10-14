using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class Persona
    {
        public string nombre = "", apellido = "";
        public int edad = 0;
        public double peso = 0.0, estatura = 0.0;

        public void cantar()
        {
            Console.WriteLine("Estoy cantando");
        }

        public void respirar()
        {
            Console.WriteLine("Estoy respirando");
        }

        public void saltar()
        {
            Console.WriteLine("Estoy respirando");
        }

        public void caminar()
        {
            Console.WriteLine("Estoy caminando");
        }

        public void escribir()
        {
            Console.WriteLine("Estoy escribiendo");
        }
    }
}
