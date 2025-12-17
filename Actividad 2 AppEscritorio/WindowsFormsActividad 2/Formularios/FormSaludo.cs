using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsActividad_2;
using WindowsFormsActividad_2.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsActividad_2.Formularios
{
    public partial class FormSaludo : Form
    {
        public FormSaludo()
        {
            InitializeComponent();
        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            MessageBox.Show("Hola "+ nombre + ", ¿Qué tal va tu día ?");
            textBoxNombre.Clear();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
             ClassIrMenu.IrAlMenu(this);
             this.Hide();


        }

        private void FormSaludo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
