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

        public void Comunicar()
        {
            Console.WriteLine("Estoy comunicado");
        }

        public void VerVideos()
        {
            Console.WriteLine("Ver videos");
        }

        public void Internet()
        {
            Console.WriteLine("Estoy en internet");
        }

        public void Calcular()
        {
            Console.WriteLine("Estoy calculando");
        }

        public void TomarFoto()
        {
            Console.WriteLine("Estoy tomando fotos");
        }
    }
}
