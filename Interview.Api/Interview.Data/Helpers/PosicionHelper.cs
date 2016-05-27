using Interview.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Data.Helpers
{
    public static class PosicionHelper
    {


        async public static Task<List<Models.Entities.PosicionDto>> GetPosiciones(Guid idusuario)
        {
            SatrackDBEntities db = new SatrackDBEntities();

            var result = new List<Models.Entities.PosicionDto>();


            List<Posiciones> posiciones = await db.Posiciones.Where(x => x.IdUsuario == idusuario).ToListAsync();
            foreach (var item in posiciones)
            {
                result.Add(new Models.Entities.PosicionDto
                {
                    Id=item.Id,
                    IdUsuario = item.IdUsuario.GetValueOrDefault(),
                    Descripcion = item.Descripcion,
                    FechaReporte = item.FechaReporte.GetValueOrDefault(),
                    Latitud = item.Latitud,
                    Longitud = item.Longitud,
                    Placa = item.Placa,

                });
            }
            return result;
        }
    }
}
