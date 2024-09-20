using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.problem7
{
    public class Empleado
    {
        private int codigo;
        private String nombre;
        private int numeroCelular;
        private double sueldoSoles;

        public Empleado(int codigo, string nombre, int numeroCelular, double sueldoSoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numeroCelular = numeroCelular;
            this.sueldoSoles = sueldoSoles;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroCelular { get => numeroCelular; set => numeroCelular = value; }
        public double SueldoSoles { get => sueldoSoles; set => sueldoSoles = value; }

        public Empleado()
        {
            codigo = 202316468;
            nombre = "Luis";
            numeroCelular = 956741625;
            sueldoSoles = 3450;
        }

        public String medirSueldo()
        {
            if (sueldoSoles > 3500)
            {
                return "Mayor a 3500";
            }
            else if (sueldoSoles < 3500)
            {
                return "Menor a 3500";
            }
            else
            {
                return "Igual a 3500";
            }

        }
    }
}
