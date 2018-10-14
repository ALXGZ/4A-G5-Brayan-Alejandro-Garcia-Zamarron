using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class TV
    {
        public string forma = "", color = "", tamaño = "", modelo = "";
        public double costo = 0.0;

        public void ver_vi()
        {
            Console.WriteLine("Estoy viendo videos");
        } 
        
        public void ver_inf()
        {
            Console.WriteLine("Estoy viendo informacion");
        }

        public void red()
        {
            Console.WriteLine("Estoy en internet");
        }

        public void musica()
        {
            Console.WriteLine("Estoy escuchando musica");
        }

        public void videojuegos()
        {
            Console.WriteLine("Estoy jugando");
        }
    }
}
