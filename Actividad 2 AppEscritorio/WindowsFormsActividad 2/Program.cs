using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsActividad_2;
using WindowsFormsActividad_2.Formularios;

namespace TuProyecto
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aquí ejecutamos nuestro ApplicationContext
            Application.Run(new FormIngreso());
        }
    }
}
