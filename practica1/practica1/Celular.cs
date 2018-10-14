using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class Celular
    {
        public string forma = "", modelo = "", color = "", material = "", tamaño = "";

        public void comunicacion()
        {
            Console.WriteLine("Estoy comunicado");
        }

        public void ver_vi()
        {
            Console.WriteLine("Ver videos");
        }

        public void red()
        {
            Console.WriteLine("Estoy en internet");
        }

        public void Calcular()
        {
            Console.WriteLine("Estoy calculando");
        }

        public void tomar_fot()
        {
            Console.WriteLine("Estoy tomando fotos");
        }
    }
}
