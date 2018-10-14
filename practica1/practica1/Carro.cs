using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class Carro
    {
        public string forma = "", color = "", tamaño = "", material = "", modelo ="";

        public void viajar()
        {
            Console.WriteLine("Esta encendido");
        }

        public void musica()
        {
            Console.WriteLine("Escuchar musica");
        }

        public void trans_obj()
        {
            Console.WriteLine("Transportar objetos");
        }

        public void cubrir()
        {
            Console.WriteLine("Estoy cubierto");
        }

        public void socializar()
        {
            Console.WriteLine("Estoy socializando");
        }
    }
}
