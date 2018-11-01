using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class carro
    {
        public string forma = "", color = "", tamaño = "", material = "", modelo = "";
        public string Viajar
        {
            get { return this.Viajar; }
            set { this.Viajar = value; }
        }

        public string EscucharMusica
        {
            get { return this.EscucharMusica; }
            set { this.EscucharMusica = value; }
        }

        public string Transportar
        {
            get { return this.Transportar; }
            set { this.Transportar = value; }
        }

        public string Cubrir
        {
            get { return this.Cubrir; }
            set { this.Cubrir = value; }
        }

        public string Socializar
        {
            get { return this.Socializar; }
            set { this.Socializar = value; }
        }

        public carro()
        {

        }

        public carro(string color, string tamaño, string velocidad, string modelo, double peso)
        {
            this.forma = forma;
            this.color = color;
            this.tamaño = tamaño;
            this.material = material;
            this.modelo = modelo;
        }
    }
}
