using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsActividad_2.Clases
{
    public class Calculadora
    {
        // Propiedades para guardar los números
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Numero3 { get; set; }
        public double Numero4 { get; set; }
        public double Numero5 { get; set; }
        public double Numero6 { get; set; }





        // Método para sumar
        public double Sumar()
        {
            return Numero1 + Numero2 + Numero3 + Numero4 + Numero5 + Numero6;
        }

        // Método para restar
        public double Restar()
        {
            return Numero1 - Numero2 - Numero3 - Numero4 - Numero5 - Numero6;
        }

        //Método para Multiplicar
        public double Multiplicar()
        {
            return Numero1 * Numero2 * Numero3 * Numero4 * Numero5 * Numero6;
        }

        //Método para divividir
        public double Dividir()
        {
            return Numero1 / Numero2 / Numero3 / Numero4 / Numero5 / Numero6;
        }
    }
    }
