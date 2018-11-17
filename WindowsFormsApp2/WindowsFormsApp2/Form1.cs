using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            Console.WriteLine(carro.Color);

            Carro carro1 = new Carro();

            carro1.Color = "Rojo";
            Console.WriteLine(carro1.Color);

            Tv tv = new Tv();
            Console.WriteLine(tv.Forma);

            Tv tv1 = new Tv();

            tv1.Forma = "Rectangular";
            Console.WriteLine(tv1.Forma);

            Persona persona = new Persona();
            Console.WriteLine(persona.Nombre);

            Persona persona1 = new Persona();

            persona1.Nombre = "Alejandro";
            Console.WriteLine(persona1.Nombre);

            Leon leon = new Leon();
            Console.WriteLine(leon.Peso);

            Leon leon1 = new Leon();

            leon1.Peso = 250;
            Console.WriteLine(leon1.Peso);

            Celular celular = new Celular();
            Console.WriteLine(celular.Forma);

            Celular celular1 = new Celular();

            celular1.Forma = "Rectangular";
            Console.WriteLine(celular1.Forma);
        }
    }
}
