using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class carro
    {
        public string forma = "", color = "", tamaño = "", material = "";
        public string modelo = "";

        public string Viajar
        {
            get { return this.Viajar; }
            set { this.Viajar = value; }
        }

        public string musica
        {
            get { return this.musica; }
            set { this.musica = value; }
        }

        public string Trans_obj
        {
            get { return this.Trans_obj; }
            set { this.Trans_obj = value; }
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
            this.modelo = modelo;
            this.material = material;
            this.modelo = modelo;
        }
    }
}
