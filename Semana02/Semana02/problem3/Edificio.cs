using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.problem3
{
    public class Edificio
    {
        private int codigo;
        private int numeroDepartamento;
        private int cantidadPisos;
        private double precioDepaDolares;

        public int Codigo { get => codigo; set => codigo = value; }
        public int NumeroDepartamento { get => numeroDepartamento; set => numeroDepartamento = value; }
        public int CantidadPisos { get => cantidadPisos; set => cantidadPisos = value; }
        public double PrecioDepaDolares { get => precioDepaDolares; set => precioDepaDolares = value; }

        public Edificio(int codigo, int numeroDepartamento, int cantidadPisos, double precioDepaDolares)
        {
            this.codigo = codigo;
            this.numeroDepartamento = numeroDepartamento;
            this.cantidadPisos = cantidadPisos;
            this.precioDepaDolares = precioDepaDolares;
        }

        public Edificio()
        {
         codigo = 15954862;
         numeroDepartamento = 20;
         cantidadPisos = 6;
         precioDepaDolares = 1000.00;
        }

        public double precioEdificioDolares() 
        {
            return this.numeroDepartamento * this.precioDepaDolares;
        
        }
    }
}
