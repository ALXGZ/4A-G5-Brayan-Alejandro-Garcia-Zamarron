using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class Laptop
    {
        public string material = "", tamaño = "", marca = "", forma = "", color = "";

        public void trabajar()
        {
            Console.WriteLine("Estoy trabajando");
        }

        public void videjuegos()
        {
            Console.WriteLine("Estoy junado");
        }

        public void guardar()
        {
            Console.WriteLine("Guardar archivos");
        }

        public void ver_vi()
        {
            Console.WriteLine("Estoy viendo videos");
        }

        public void red()
        {
            Console.WriteLine("Estoy en internet");
        }
    }
}
