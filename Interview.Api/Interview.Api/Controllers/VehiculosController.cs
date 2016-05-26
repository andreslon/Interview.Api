using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Interview.Data.Models;
using Interview.Data.Models.Entities;
using System.Web.Routing;

namespace Interview.Api.Controllers
{
    public class VehiculosController : ApiController
    {
        private SatrackDBEntities db = new SatrackDBEntities();
        /// <summary>
        /// Permite obtener los vehiculos de un usuario con su respectiva información de posicionamiento
        /// </summary>
        /// <param name="id">Id del usuario</param>
        /// <returns>Retorna una lista de tipo posiciones, compuesta por la cantidad de vehiculos pertenecientes a un usuario</returns>
        [ResponseType(typeof(Posiciones))]
        public async Task<IHttpActionResult> GetPosiciones(Guid idusuario)
        {
            List<Posiciones> posiciones = await db.Posiciones.Where(x => x.IdUsuario == idusuario).ToListAsync();
            if (posiciones == null)
            {
                return NotFound();
            }

            return Ok(posiciones);
        }

        /// <summary>
        /// Permite almacenar un evento recibido en la solicitud
        /// </summary>
        /// <param name="evento">Estructura para generar alguna acción en el vehiculo</param>
        /// <returns>Retorna la respuesta del procesamiento realizado</returns>
        [Route("api/Vehiculos/Evento")]
        [ResponseType(typeof(bool))]
        public IHttpActionResult PostEvento(EventoDto evento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(true);
        }
    }
}
