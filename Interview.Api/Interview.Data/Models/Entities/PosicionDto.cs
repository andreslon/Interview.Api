using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Data.Models.Entities
{
    public class PosicionDto
    {
        public System.Guid Id { get; set; }
        public System.Guid IdUsuario { get; set; }
        public string Placa { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaReporte { get; set; }
        
    }
}
