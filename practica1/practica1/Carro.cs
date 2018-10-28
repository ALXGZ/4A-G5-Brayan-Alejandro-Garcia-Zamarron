using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class Carro
    {
        public string forma = "", color = "", tamaño = "", material = "", modelo = "";

        public void Viajar()
        {
            Console.WriteLine("Estoy viajando");
        }

        public void Musica()
        {
            Console.WriteLine("Escuchar musica");
        }

        public void Transportar()
        {
            Console.WriteLine("Transportar objetos");
        }

        public void Cubrir()
        {
            Console.WriteLine("Estoy cubierto");
        }

        public void Socializar()
        {
            Console.WriteLine("Estoy socializando");
        }
    }
}
