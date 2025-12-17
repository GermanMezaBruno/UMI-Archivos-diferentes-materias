using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsActividad_2.Clases;

namespace WindowsFormsActividad_2.Formularios
{
    public partial class FormOperacionesBasicas : Form
    {
        Calculadora calc = new Calculadora();


        public FormOperacionesBasicas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Esta es una forma pero es mas tardada 
              double num1;
              double num2;
              double num3;
              double num4;
              double num5;
              double num6;
              num1 = double.Parse(textBoxPrimerNum.Text);
              num2 = double.Parse(textBoxSegundoNum.Text);
              num3 = double.Parse(textBoxTercerNum.Text);
              num4 = double.Parse(textBoxCuartoNum.Text);
              num5 = double.Parse(textBoxQuintoNum.Text);
              num6 = double.Parse(textBoxSextoNum.Text);


              double suma  = num1 + num2 + num3 + num4 + num5 + num6;
              textBoxResultado.Text = suma.ToString();*/

            /*Esta es otra forma
            double numero1 = Convert.ToDouble(textBoxPrimerNum.Text);
            double numero2 = Convert.ToDouble(textBoxSegundoNum.Text);
            double numero3 = Convert.ToDouble(textBoxTercerNum.Text);
            double numero4 = Convert.ToDouble(textBoxCuartoNum.Text);
            double numero5 = Convert.ToDouble(textBoxQuintoNum.Text);
            double numero6 = Convert.ToDouble(textBoxSextoNum.Text);

            double suma = numero1 + numero2 + numero3 + numero4 + numero5 + numero6;
            textBoxResultado.Text = suma.ToString();*/

            {
                // Sacamos los números de los TextBox
                calc.Numero1 = Convert.ToDouble(textBoxPrimerNum.Text);
                calc.Numero2 = Convert.ToDouble(textBoxSegundoNum.Text);
                calc.Numero3 = Convert.ToDouble(textBoxTercerNum.Text);
                calc.Numero4 = Convert.ToDouble(textBoxCuartoNum.Text);
                calc.Numero5 = Convert.ToDouble(textBoxQuintoNum.Text);
                calc.Numero6 = Convert.ToDouble(textBoxSextoNum.Text) ;

                // Mostramos el resultado en el TextBox resultado
                textBoxResultado.Text = calc.Sumar().ToString();
            }








        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxPrimerNum.Clear();
            textBoxSegundoNum.Clear();
            textBoxTercerNum.Clear();
            textBoxCuartoNum.Clear();
            textBoxQuintoNum.Clear();
            textBoxSextoNum.Clear();
            textBoxResultado.Clear();


        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormOperacionesBasicas_Load(object sender, EventArgs e)
        {
            textBoxResultado.ReadOnly = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sacamos los números de los TextBox
            calc.Numero1 = Convert.ToDouble(textBoxPrimerNum.Text);
            calc.Numero2 = Convert.ToDouble(textBoxSegundoNum.Text);
            calc.Numero3 = Convert.ToDouble(textBoxTercerNum.Text);
            calc.Numero4 = Convert.ToDouble(textBoxCuartoNum.Text);
            calc.Numero5 = Convert.ToDouble(textBoxQuintoNum.Text);
            calc.Numero6 = Convert.ToDouble(textBoxSextoNum.Text);

            // Mostramos el resultado en el TextBox resultado
            textBoxResultado.Text = calc.Restar().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sacamos los números de los TextBox
            calc.Numero1 = Convert.ToDouble(textBoxPrimerNum.Text);
            calc.Numero2 = Convert.ToDouble(textBoxSegundoNum.Text);
            calc.Numero3 = Convert.ToDouble(textBoxTercerNum.Text);
            calc.Numero4 = Convert.ToDouble(textBoxCuartoNum.Text);
            calc.Numero5 = Convert.ToDouble(textBoxQuintoNum.Text);
            calc.Numero6 = Convert.ToDouble(textBoxSextoNum.Text);

            // Mostramos el resultado en el TextBox resultado
            textBoxResultado.Text = calc.Multiplicar().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            calc.Numero1 = Convert.ToDouble(textBoxPrimerNum.Text);
            calc.Numero2 = Convert.ToDouble(textBoxSegundoNum.Text);
            calc.Numero3 = Convert.ToDouble(textBoxTercerNum.Text);
            calc.Numero4 = Convert.ToDouble(textBoxCuartoNum.Text);
            calc.Numero5 = Convert.ToDouble(textBoxQuintoNum.Text);
            calc.Numero6 = Convert.ToDouble(textBoxSextoNum.Text);
            textBoxResultado.Text = calc.Dividir().ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClassIrMenu.IrAlMenu(this);
            this.Hide();

        }

        private void FormOperacionesBasicas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
