using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsActividad_2.Formularios
{
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "")
            {
                MessageBox.Show("Debes ingresar una contraseña ");
                textBoxContraseña.Clear();
            }

            else if (textBoxContraseña.Text != "UMI")
            {
                FormError error = new FormError();
                error.Show(); //Muestra el formulario que cree como pantalla de error
                textBoxContraseña.Clear();
               

            }

            else if (textBoxContraseña.Text == "UMI")
            {
                FormMenu menu = new FormMenu();
                menu.Show();
                this.Hide();
              
            }
        }
    }
}
