using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.problem4
{
    public class Obrero
    {
        private int codigo;
        private String nombre;
        private int horasTrabajadas;
        private double tarifaPorHora;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public double TarifaPorHora { get => tarifaPorHora; set => tarifaPorHora = value; }

        public Obrero(int codigo, string nombre, int horasTrabajadas, double tarifaPorHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaPorHora = tarifaPorHora;
        }

        public Obrero()
        {
        }

        public double sueldoBruto()
        {
            return this.horasTrabajadas * this.tarifaPorHora;
        
        }

        public double descuentoAFP()
        {
            return this.sueldoBruto() * 0.10;
        }

        public double descuentoEPS()
        { 
            return this.sueldoBruto() * 0.05;
        
        }

        public double sueldoNeto()
        {
            return this.sueldoBruto() - this.descuentoAFP() - this.descuentoEPS() ;
        }

     
    }
}
