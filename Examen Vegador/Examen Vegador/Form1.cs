using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Vegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Vengador capi = new Vengador("Capitan America", "Mascuino", 70);
            capi.Nombre = "Capitan America";
            capi.UsarEquipamiento();

            Vengador dios  = new Vengador();
            dios.Nombre = "Thor";
            dios.UsarEquipamiento();

            ViudaNegra espia = new ViudaNegra();
            espia.Nombre = "Viuda negra";
            espia.UsarEquipamiento();

            Barton alcohon = new Barton();
            alcohon.Nombre = "Barton";
            alcohon.UsarEquipamiento();

            IronMan hierro = new IronMan();
            hierro.Nombre = "Iron Man";
            hierro.UsarEquipamiento();

            Hulk verde = new Hulk();
            verde.Nombre = "Hulk";
            verde.UsarEquipamiento();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
