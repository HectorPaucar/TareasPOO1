using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Semana02.problem1
{
    public class Celular
    {

        private int numero;
        private String usuario;
        private int segundos;
        private double precio;

        public int Numero { get => numero; set => numero = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public int Segundos { get => segundos; set => segundos = value; }
        public double Precio { get => precio; set => precio = value; }

        public Celular(int numero, string usuario, int segundos, double precio)
        {
            this.Numero = numero;
            this.Usuario = usuario;
            this.Segundos = segundos;
            this.Precio = precio;
        }

        public Celular()
        {
        }

        public double costoPorConsumo() {

            return this.Segundos * this.Precio;
        }


        public double impuestoPorIGV() {
            return costoPorConsumo() * 0.18;
        }

        public double totalPagar()
        {
            return costoPorConsumo() + impuestoPorIGV();
        }

    }
}
