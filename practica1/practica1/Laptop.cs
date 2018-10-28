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

        public void Trabajar()
        {
            Console.WriteLine("Estoy trabajando");
        }

        public void VideoJuegos()
        {
            Console.WriteLine("Estoy jugando Videojuegos");
        }

        public void Guardar()
        {
            Console.WriteLine("Guardar archivos");
        }

        public void VerVideos()
        {
            Console.WriteLine("Estoy viendo videos");
        }

        public void Informacion()
        {
            Console.WriteLine("Estoy en internet");
        }
    }
}
