using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.problem9
{
    public class Pelota
    {
        private String marca;
        private double pesoGramos;
        private double presionLibras;
        private double diametroCentimetros;
        private double precio;

        public Pelota()
        {
        }

        public Pelota(string marca, double pesoGramos, double presionLibras, double diametroCentimetros, double precio)
        {
            this.marca = marca;
            this.pesoGramos = pesoGramos;
            this.presionLibras = presionLibras;
            this.diametroCentimetros = diametroCentimetros;
            this.precio = precio;
        }

        public string Marca { get => marca; set => marca = value; }
        public double PesoGramos { get => pesoGramos; set => pesoGramos = value; }
        public double PresionLibras { get => presionLibras; set => presionLibras = value; }
        public double DiametroCentimetros { get => diametroCentimetros; set => diametroCentimetros = value; }
        public double Precio { get => precio; set => precio = value; }


        public double radio()
        {
            return this.diametroCentimetros / 2;
        }

        public double volumenBalon()
        {
            return 4 * 3.1416 * radio() * radio() * radio() / 3; 
        }

        public double descuento()
        {
            return this.precio * 0.10;
        }

        public double importePago()
        { 
            return this.precio - descuento();
        
        }
    }
}
