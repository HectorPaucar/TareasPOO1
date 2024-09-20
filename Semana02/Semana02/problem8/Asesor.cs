using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.problem8
{
    public class Asesor
    {
        private int codigo;
        private String nombre;
        private int horasTrabajadas;
        private double tarifaPorHora;


        public Asesor(int codigo, string nombre, int horasTrabajadas, double tarifaPorHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaPorHora = tarifaPorHora;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public double TarifaPorHora { get => tarifaPorHora; set => tarifaPorHora = value; }

        public Asesor()
        {
        }

        public double sueldoBruto()
        {
            return this.horasTrabajadas * this.tarifaPorHora;
        }

        public double descuento()
        {
            return sueldoBruto() * 0.15;
        
        }

        public double sueldoNeto()
        {
            return sueldoBruto() - descuento();   
        }
    }


}
