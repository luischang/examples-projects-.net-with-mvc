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
    
    public partial class CinePelicula
    {
        public int CodCine { get; set; }
        public int CodPelicula { get; set; }
        public Nullable<bool> EnCartelera { get; set; }
    
        public virtual Cine Cine { get; set; }
        public virtual Pelicula Pelicula { get; set; }
    }
}
