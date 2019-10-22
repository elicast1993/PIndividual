using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIndividual.BL;

namespace PIndividual.ConsolaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Prueba p = new Prueba();


            p.AgregarVuelos();
            Console.WriteLine("Se ha insertado un vuelo");
            p.AgregarPasajeros();
            Console.WriteLine("Se ha insertado un pasajero");
            p.AgregarAviones();
            Console.WriteLine("Se ha insertado un avión");
            p.AgregarPaisesDestinoAeropuerto();
            Console.WriteLine("Se ha insertado un Paises/Destino/Aeropuerto");

            // ni me cierra pantalla de consola hasta no precionar una tecla.
            Console.ReadKey();

        }
    }
}
