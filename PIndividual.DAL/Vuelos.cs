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
    
    public partial class Vuelos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vuelos()
        {
            this.Paises_Destino_Aeropuerto = new HashSet<Paises_Destino_Aeropuerto>();
        }
    
        public int Id_vuelo { get; set; }
        public string Escala { get; set; }
        public int Duracion { get; set; }
        public bool Round_trip { get; set; }
        public string Tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paises_Destino_Aeropuerto> Paises_Destino_Aeropuerto { get; set; }
    }
}
