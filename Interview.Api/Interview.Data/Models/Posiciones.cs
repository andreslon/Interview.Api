//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Interview.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Posiciones
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> IdUsuario { get; set; }
        public string Placa { get; set; }
        public Nullable<decimal> Latitud { get; set; }
        public Nullable<decimal> Longitud { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaReporte { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
