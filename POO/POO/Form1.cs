using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            Console.WriteLine("");
            Persona persona = new Persona();
            Console.WriteLine("-Persona-");
            persona.nombre = "Alex";
            Console.WriteLine("Persona = " + persona.nombre);
            persona.apellido = "García";
            Console.WriteLine("Apellido = " + persona.apellido);
            persona.edad = 19;
            Console.WriteLine("Edad = " + persona.edad);
            persona.estatura = 1.75;
            Console.WriteLine("Estatura = " + persona.estatura);
            persona.peso = 56;
            Console.WriteLine("Peso = " + persona.peso);
            Console.WriteLine("-Actividades-");
            persona.cantar();
            persona.respirar();
            persona.saltar();
            persona.caminar();
            persona.escribir();

            Console.WriteLine("");
            Console.WriteLine("-Laptop-");
            Laptop Laptop = new Laptop();
            Laptop.material = "Plastico";
            Console.WriteLine("Material = " + Laptop.material);
            Laptop.cables = 325;
            Console.WriteLine("Cables = " + Laptop.cables);
            Laptop.circuitos = 19;
            Console.WriteLine("Circuitos = " + Laptop.circuitos);
            Laptop.forma = "Rectangular";
            Console.WriteLine("Forma Física = " + Laptop.forma);
            Laptop.color = "Negro";
            Console.WriteLine("Color = " + Laptop.color);
            Console.WriteLine("-Actividades-");
            Laptop.trabajar();
            Laptop.videojuegos();
            Laptop.guardar();
            Laptop.ver_vi();
            Laptop.red();

            Console.WriteLine("");
            Console.WriteLine("-Celular-");
            Celular Celular = new Celular();
            Celular.forma = "Rectangular";
            Console.WriteLine("Forma física = " + Celular.forma);
            Celular.color = "Negro";
            Console.WriteLine("Color = " + Celular.color);
            Celular.modelo = "Hisense";
            Console.WriteLine("Modelo = " + Celular.modelo);
            Celular.material = "Plastico";
            Console.WriteLine("Material = " + Celular.material);
            Celular.tamaño = "3 x 2 cm";
            Console.WriteLine("Tamaño = " + Celular.tamaño);
            Console.WriteLine("-Actividades-");
            Celular.comunicacion();
            Celular.ver_vi();
            Celular.red();
            Celular.calcular();
            Celular.tomar_fo();

            Console.WriteLine("");
            Console.WriteLine("-TV-");
            TV TV = new TV();
            TV.forma = "Rectangular";
            Console.WriteLine("Forma física = " + TV.forma);
            TV.color = "Negro";
            Console.WriteLine("Color = " + TV.color);
            TV.cables = 76;
            Console.WriteLine("Cables = " + TV.cables);
            TV.material = "Plastico";
            Console.WriteLine("Material = " + TV.material);
            TV.tamaño = "5 x 3";
            Console.WriteLine("Tamaño = " + TV.tamaño);
            Console.WriteLine("-Actividades-");
            TV.ver_vi();
            TV.Ver_inf();
            TV.red();
            TV.musica();
            TV.videojuegos();

            Console.WriteLine("");
            Console.WriteLine("-Carro-");
            Carro Carro = new Carro();
            Carro.forma = "Rectangular";
            Console.WriteLine("Forma física = " + Carro.forma);
            Carro.color = "Blanco";
            Console.WriteLine("Color = " + Carro.color);
            Carro.material = "Metal";
            Console.WriteLine("Material = " + Carro.material);
            Carro.tamaño = "5 x 3";
            Console.WriteLine("Tamaño = " + Carro.tamaño);
            Carro.modelo = "SEAT";
            Console.WriteLine("Modelo = " + Celular.modelo);
            Console.WriteLine("-Funciones-");
            Carro.viajar();
            Carro.musica();
            Carro.trans_obj();
            Carro.cubrir();
            Carro.socializar();

            Console.WriteLine("");
            Leon Leon = new Leon();
            Console.WriteLine("-Leon-");
            Leon.sexo = "Macho";
            Console.WriteLine("Sexo = " + Leon.sexo);
            Leon.edad = 56;
            Console.WriteLine("Edad = " + Leon.edad);
            Leon.salud = "Buena";
            Console.WriteLine("Salud = " + Leon.salud);
            Leon.estatura = 1.5;
            Console.WriteLine("Estatura = " + Leon.estatura);
            Leon.peso = 190;
            Console.WriteLine("Peso = " + Leon.peso);
            Console.WriteLine("-Actividades-");
            persona.peso = 56;
            Leon.Nutrirce();
            Leon.Dormir();
            Leon.Trepar();
            Leon.reproducirce();
            Leon.Respirar();        }
    }
}