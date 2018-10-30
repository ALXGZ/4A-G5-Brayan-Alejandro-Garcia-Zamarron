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

        public void VerVideos()
        {
            Console.WriteLine("Estoy viendo videos");
        } 
        
        public void VerInformacion()
        {
            Console.WriteLine("Estoy viendo informacion");
        }

        public void NavegarEnInternet()
        {
            Console.WriteLine("Estoy en internet");
        }

        public void EscucharMusica()
        {
            Console.WriteLine("Estoy escuchando musica");
        }

        public void JugarVideoJuegos()
        {
            Console.WriteLine("Estoy jugando");
        }
    }
}
