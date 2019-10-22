using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIndividual.DAL;

namespace PIndividual.BL
{
    public class Prueba
    {

        public void AgregarVuelos()
        {
            Vuelos v = new Vuelos();
           
            v.Escala = "xxx";
            v.Duracion = 5;
            v.Id_vuelo = 2;
            using (AeropuertoEntities context = new AeropuertoEntities())
            {

                context.Vuelos.Add(v);
                context.SaveChanges();

            }

        }

        public void AgregarPasajeros()
        {
            Pasajeros p = new Pasajeros();

            p.Id_vuelo = 123456;
            p.Nombre = "Juan";
            p.Apellidos = "Ortiz";
            p.Visa = 0123456;
            p.Pasaporte = 005123456;

            using (AeropuertoEntities context = new AeropuertoEntities())
            {

                context.Pasajeros.Add(p);
                context.SaveChanges();

            }

        }


        public void AgregarAviones()
        {
            Aviones a = new Aviones();

            a.Modelo = "789-9 Dreamliner";
            a.Asientos = "217-323";
            a.Cantidad = 200;

            using (AeropuertoEntities context = new AeropuertoEntities())
            {

                context.Aviones.Add(a);
                context.SaveChanges();

            }

        }

        public void AgregarPaisesDestinoAeropuerto()
        {
            Paises_Destino_Aeropuerto pda = new Paises_Destino_Aeropuerto();

            pda.id_vuelo = 1;
            pda.Paises = "Canada";
            pda.Destino = "	Ottawa";
            pda.Aeropuerto = "Aeropuerto Internacional Toronto Pearson";
            pda.Tarifa = 322.616;

            using (AeropuertoEntities context = new AeropuertoEntities())
            {

                context.Paises_Destino_Aeropuerto.Add(pda);
                context.SaveChanges();

            }

        }


       


        public void PruebaSelect()
        {


            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                var vuelos = context.Vuelos.ToList();
                
            }

           
            
        }

        public void PruebaWhere()
        {


            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                try
                {
                    var vuelos = context.Vuelos.Where(x => x.Id_vuelo == 4);

                }
                catch (Exception e)
                {


                    Console.WriteLine("e");
                }

            }
        }

        public void PruebaWhere2()
        {


            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                try
                {
                    var vuelos = context.Vuelos.Where(x => x.Duracion == 5);


                }
                catch (Exception e)
                {


                    Console.WriteLine("e");
                }

            }
        }

        public void PruebaJoin()
        {


            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                //T representa una tupla en este caso tenemos T1 que es la tupla 1 y t2 que es la tupla 2 
                //T Este caso presenta un Inner Join
                try
                {
                    var vuelos = context.Vuelos.Join(context.Paises_Destino_Aeropuerto,
                        t2 => t2.Id_vuelo,
                        t1 => t1.id,
                        (t1, t2) => new
                        {

                            escala = t1.Escala,
                            destino = t2.Destino

                        }
                        ).ToList();
                }
                catch (Exception e)
                {


                    Console.WriteLine("e");

                }

            }



        }



        public void PruebaWhereSelect()
        {
            //T lambda es una funcion en este ejemplo s es esa funcion sx tiene la misma función

            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                try
                {
                    var vuelos = context.Vuelos.Where(x => x.Duracion == 5).Select(s =>
                    new
                    {

                        Escala = s.Escala,
                        Duracion = s.Duracion


                    }
                    ).ToList();

                }
                catch (Exception e)
                {


                    Console.WriteLine("e");
                }

            }



        }

        public void PruebaUpdate()
        {
            //

            using (AeropuertoEntities context = new AeropuertoEntities())
            {
                try
                {
                    var vuelo = context.Vuelos.Where(x => x.Duracion == 5).SingleOrDefault();
                    vuelo.Escala = "CAMBIO";
                    context.SaveChanges();

                }
                catch (Exception e)
                {


                    Console.WriteLine("e");
                }

            }
        }
    }
}