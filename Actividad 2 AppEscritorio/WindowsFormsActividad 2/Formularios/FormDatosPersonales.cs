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
    public partial class FormDatosPersonales : Form
    {
        public FormDatosPersonales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassIrMenu.IrAlMenu(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassIrMenu.IrAlMenu(this);
            this.Hide();
        }

        private void FormDatosPersonales_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
