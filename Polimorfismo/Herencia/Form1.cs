using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Perro perro = new Perro();
			perro.Nombre = "Max";

			perro.Comer();
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
