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
            carro carro = new carro();
            Console.WriteLine(carro.color);

            carro carro1 = new carro();

            carro1.modelo = "Rojo";
            Console.WriteLine(carro1.color);

            tv tv = new tv();
            Console.WriteLine(tv.forma);

            tv tv1 = new tv();

            tv1.forma = "Rectangular";
            Console.WriteLine(tv1.forma);

            persona persona = new persona();
            Console.WriteLine(persona.sexo);

            persona persona1 = new persona();

            persona1.Cantar = "Hombre";
            Console.WriteLine(persona1.sexo);

            leon leon = new leon();
            Console.WriteLine(leon.Alimetar);

            leon leon1 = new leon();

            leon1.Cazar = "Carne";
            Console.WriteLine(leon1.Alimetar);

            celular celular = new celular();
            Console.WriteLine(celular.Red);

            celular celular1 = new celular();

            celular1.Red = "Informacion";
            Console.WriteLine(celular1.Red);
        }
    }
}
