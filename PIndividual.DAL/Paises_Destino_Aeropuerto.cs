//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIndividual.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paises_Destino_Aeropuerto
    {
        public int id { get; set; }
        public int id_vuelo { get; set; }
        public string Paises { get; set; }
        public string Destino { get; set; }
        public string Aeropuerto { get; set; }
        public double Tarifa { get; set; }
    
        public virtual Vuelos Vuelos { get; set; }
    }
}
