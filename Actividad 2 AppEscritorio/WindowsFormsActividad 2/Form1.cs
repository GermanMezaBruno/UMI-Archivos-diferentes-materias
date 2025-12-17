using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsActividad_2.Formularios;

namespace WindowsFormsActividad_2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatosPersonales datos = new FormDatosPersonales();
            datos.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaludo saludo = new FormSaludo();
            saludo.Show();
            this.Hide();
        }

        private void operacionesBasicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOperacionesBasicas basicas = new FormOperacionesBasicas();
            basicas.Show();
            this.Hide();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
