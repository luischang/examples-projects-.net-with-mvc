//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreCine
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asiento
    {
        public Asiento()
        {
            this.Ticket = new HashSet<Ticket>();
        }
    
        public int CodAsiento { get; set; }
        public string DescripcionAsiento { get; set; }
        public Nullable<int> CodSala { get; set; }
        public Nullable<int> TipoAsiento { get; set; }
        public Nullable<bool> Disponible { get; set; }
    
        public virtual Sala Sala { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
