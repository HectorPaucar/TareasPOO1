using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02.problem5
{
    public class Video
    {
        private int codigo;
        private String nombreVideo;
        private double duracion;
        private double precioSoles;
        private double tipoCambio;

        public int Codigo { get => codigo; set => codigo = value; }
        public string NombreVideo { get => nombreVideo; set => nombreVideo = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public double PrecioSoles { get => precioSoles; set => precioSoles = value; }
        public double TipoCambio { get => tipoCambio; set => tipoCambio = value; }

        public Video(int codigo, string nombreVideo, double duracion, double precioSoles, double tipóCambio)
        {
            this.codigo = codigo;
            this.nombreVideo = nombreVideo;
            this.duracion = duracion;
            this.precioSoles = precioSoles;
            this.tipoCambio = tipóCambio;
        }

        public Video()
        {
        }

        public double precioDolares()
        {
            return this.precioSoles / this.tipoCambio;
        }
    }
}
