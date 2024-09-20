using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.Problem2
{
    public class Computadora
    {
        private int codigo;
        private String marca;
        private String color;
        private double precioDolares;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioDolares { get => precioDolares; set => precioDolares = value; }

        public Computadora(int codigo, string marca, string color, double precioDolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precioDolares = precioDolares;
        }
        public Computadora()
        {
        }

        public double precioPcSoles() {
            return this.precioDolares * 3.35;
        }

        public double precioPcEuros()
        {
            return this.precioDolares * 1.20;
        }
    }
}
