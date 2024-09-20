using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.problem6
{
    public class Paciente
    {
        private String nombre;
        private String apellido;
        private int edad;
        private double talla;
        private double peso;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Talla { get => talla; set => talla = value; }
        public double Peso { get => peso; set => peso = value; }

        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }

        public Paciente()
        {
        }

        public String verificarEdad()
        {
            if (edad < 18)
            {
                return "menor de edad";
            }
            else
            {
                return "mayor de edad";
            }
        }
    }
}
