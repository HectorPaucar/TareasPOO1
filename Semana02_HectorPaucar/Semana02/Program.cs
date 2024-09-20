using Semana02.problem1;
using Semana02.Problem2;
using Semana02.problem3;
using Semana02.problem4;
using Semana02.problem5;
using Semana02.problem6;
using Semana02.problem7;
using Semana02.problem8;
using Semana02.problem9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Semana02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Problema1*/
             Celular celular = new Celular(986809252, "Alvaro", 60, 1.40); 
               listado(celular);
               celular.Segundos += 20;
               celular.Precio -= celular.Precio * 0.05;
               listado(celular);       
            

            /*Problema2*/
            /*Computadora computadora = new Computadora(14786278, "Asus", "Negro", 549.99);
              listado(computadora);
              computadora.PrecioDolares -= computadora.PrecioDolares * 0.10;
              listado(computadora);
            */

            /*Problema3*/
           /* Edificio edificio = new Edificio();
            listado(edificio);
            edificio.PrecioDepaDolares += edificio.PrecioDepaDolares * 0.20;
            listado(edificio);
          */

            /*Problema4*/
           /* Obrero obrero = new Obrero(18572694, "Adolfo", 50, 30);
            listado(obrero);
            obrero.HorasTrabajadas +=  8;
            listado(obrero);
            */

            /*Problema5*/
            /*  Video video = new Video(45680321, "Distrito10", 15,50,3.75);
              listado(video);
              video.PrecioSoles += 5.50;
              listado(video);
            */

            /*Problema6*/
            /* Paciente paciente = new Paciente("Andre", "Suarez", 25, 1.85, 82);
             listado(paciente);
             paciente.Edad = 13;
             listado(paciente);
            */

            /*Problema7*/
            /* Empleado empleado = new Empleado();
             listado(empleado);
             empleado.NumeroCelular = 795026835;
             empleado.SueldoSoles += 50;
             listado(empleado);
             empleado.SueldoSoles += 200;
             listado(empleado);
            */

            /*Problema8*/
            /*Asesor asesor = new Asesor(56879523, "Pedro", 80, 30);
            listado(asesor);
            asesor.HorasTrabajadas += 10;
            asesor.TarifaPorHora -= asesor.TarifaPorHora  * 0.15;  
            listado(asesor);
            */

            /*Problema9*/
          /*  Pelota pelota = new Pelota("Adidas", 500, 8, 21.65, 300);
            listado(pelota);
            pelota.Precio -= pelota.Precio * 0.25;
            pelota.DiametroCentimetros += 1;
            listado(pelota);
           */
        }
        /*Problema1*/
          public static void listado(Celular celular)
               {
                   Console.WriteLine("Usuario Celular: " + celular.Usuario);
                   Console.WriteLine("Numero Celular: " + celular.Numero);
                   Console.WriteLine("Segundos Consumidos: " + celular.Segundos);
                   Console.WriteLine("Precio por segundo Celular: " + celular.Precio);

                   Console.WriteLine("Costo por consumo de segundos: " + celular.costoPorConsumo());
                   Console.WriteLine("Impuesto por consumo de segundos: " + celular.impuestoPorIGV());
                   Console.WriteLine("Total a pagar: " + celular.totalPagar());
                   Console.WriteLine("\n");

               }
        

        /*Problema2*/
           /*   public static void listado(Computadora computadora)
                {
                   Console.WriteLine("Codigo Computadora: " + computadora.Codigo);
                   Console.WriteLine("Marca Computadora: " + computadora.Marca);
                   Console.WriteLine("Color: " + computadora.Color);
                   Console.WriteLine("Precio en Dolares: " + computadora.PrecioDolares);

                   Console.WriteLine("Precio en Soles: " + computadora.precioPcSoles());
                   Console.WriteLine("Precio en Euros: " + computadora.precioPcEuros());
                   Console.WriteLine("\n");
                }
        */

        /*Problema3*/
         /*    public static void listado(Edificio edificio)
             { 

                 Console.WriteLine("Codigo: " + edificio.Codigo);
                 Console.WriteLine("Numero de Departamentos: " + edificio.NumeroDepartamento);
                 Console.WriteLine("Cantidad de pisos: " + edificio.CantidadPisos);
                 Console.WriteLine("Precio Departamento en Dolares: " + edificio.PrecioDepaDolares);

                 Console.WriteLine("Precio en Dolares " + edificio.precioEdificioDolares());
                 Console.WriteLine("\n");
               }
         */
        

        /*Problema4*/
        /* public static void listado(Obrero obrero)
         {
             Console.WriteLine("Codigo: " + obrero.Codigo);
             Console.WriteLine("Nombre del obrero: " + obrero.Nombre);
             Console.WriteLine("Horas trabajadas: " + obrero.HorasTrabajadas);
             Console.WriteLine("Tarifa por hora: " + obrero.TarifaPorHora);

             Console.WriteLine("Descuento por AFP: " + obrero.descuentoAFP());
             Console.WriteLine("Descuento por EPS: " + obrero.descuentoEPS());
             Console.WriteLine("Sueldo Neto: " + obrero.sueldoNeto());
             Console.WriteLine("\n");
         }
        
        */

        /*Problema5*/
        /* public static void listado(Video video)
         {
             Console.WriteLine("Codigo: " + video.Codigo);
             Console.WriteLine("Nombre del video: " + video.NombreVideo);
             Console.WriteLine("Duración del video: " + video.Duracion);
             Console.WriteLine("Precio en soles: " + video.PrecioSoles);
             Console.WriteLine("Tipo de cambio: " + video.TipoCambio);

             Console.WriteLine("Precio en dolares: " + video.precioDolares());
             Console.WriteLine("\n");
         }
        */


        /*Problema6*/
        /*public static void listado(Paciente paciente)
        {
            Console.WriteLine("Nombre paciente: " + paciente.Nombre);
            Console.WriteLine("Nombre apellido: " + paciente.Apellido);
            Console.WriteLine("Edad paciente: " + paciente.Edad);
            Console.WriteLine("Talla paciente: " + paciente.Talla);
            Console.WriteLine("Peso paciente: " + paciente.Peso);

            Console.WriteLine("Verificar edad: " + paciente.verificarEdad());
            Console.WriteLine("\n");
        }
        */


        /*Problema7*/
       /* public static void listado(Empleado empleado)
         {
             Console.WriteLine("Codigo empleado: " + empleado.Codigo);
             Console.WriteLine("Nombre empleado: " + empleado.Nombre);
             Console.WriteLine("Numero de celular: " + empleado.NumeroCelular);
             Console.WriteLine("Sueldo de empleado: " + empleado.SueldoSoles);

             Console.WriteLine("Consulta de sueldo: " + empleado.medirSueldo());
             Console.WriteLine("\n");
         }
        */


        /*Problema8*/
        /*  public static void listado(Asesor asesor)
          {
              Console.WriteLine("Codigo asesor: " + asesor.Codigo);
              Console.WriteLine("Nombre asesor: " + asesor.Nombre);
              Console.WriteLine("Horas de trabajo: " + asesor.HorasTrabajadas);
              Console.WriteLine("Tarifa por hora: " + asesor.TarifaPorHora);

              Console.WriteLine("Sueldo Bruto: " + asesor.sueldoBruto());
              Console.WriteLine("Descuento: " + asesor.descuento());
              Console.WriteLine("Sueldo Neto: " + asesor.sueldoNeto());
              Console.WriteLine("\n");
          }
        */

        /*Problema9*/
     /*  public static void listado(Pelota pelota)
        {
            Console.WriteLine("MARCA DE PELOTA: " + pelota.Marca);
            Console.WriteLine("PESO EN GRAMOS: " + pelota.PesoGramos);
            Console.WriteLine("PRESION EN LIBRAS: " + pelota.PresionLibras);
            Console.WriteLine("DIAMETRO EN CENTIMETROS: " + pelota.DiametroCentimetros);
            Console.WriteLine("PRECIO DE LA PELOTA: " + pelota.Precio);

            Console.WriteLine("RADIO PELOTA: " + pelota.radio());
            Console.WriteLine("VOLUMEN PELOTA: " + pelota.volumenBalon());
            Console.WriteLine("DESCUENTO PRECIO: " + pelota.descuento());
            Console.WriteLine("IMPORTE A PAGAR: " + pelota.importePago());
            Console.WriteLine("\n");
        }
      */
    }
}
