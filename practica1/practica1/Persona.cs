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
