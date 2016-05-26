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

namespace Interview.Api.Controllers
{
    public class PosicionesController : ApiController
    {
        private SatrackDBEntities db = new SatrackDBEntities();

        //// GET: api/Posiciones
        //public IQueryable<Posiciones> GetPosiciones()
        //{
        //    return db.Posiciones;
        //}
        /// <summary>
        /// Permite obtener los vehiculos de un usuario con su respectiva información de posicionamiento
        /// </summary>
        /// <param name="id">Id del usuario</param>
        /// <returns>Retorna una lista de tipo posiciones, compuesta por la cantidad de vehiculos pertenecientes a un usuario</returns>
        // GET: api/Posiciones/5
        [ResponseType(typeof(Posiciones))]
        public async Task<IHttpActionResult> GetPosiciones(Guid idusuario)
        {
            List<Posiciones> posiciones = await db.Posiciones.Where(x=> x.IdUsuario== idusuario).ToListAsync();
            if (posiciones == null)
            {
                return NotFound();
            }

            return Ok(posiciones);
        }

        //// PUT: api/Posiciones/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutPosiciones(Guid id, Posiciones posiciones)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != posiciones.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(posiciones).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PosicionesExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Posiciones
        //[ResponseType(typeof(Posiciones))]
        //public async Task<IHttpActionResult> PostPosiciones(Posiciones posiciones)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Posiciones.Add(posiciones);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (PosicionesExists(posiciones.Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = posiciones.Id }, posiciones);
        //}

        //// DELETE: api/Posiciones/5
        //[ResponseType(typeof(Posiciones))]
        //public async Task<IHttpActionResult> DeletePosiciones(Guid id)
        //{
        //    Posiciones posiciones = await db.Posiciones.FindAsync(id);
        //    if (posiciones == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Posiciones.Remove(posiciones);
        //    await db.SaveChangesAsync();

        //    return Ok(posiciones);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PosicionesExists(Guid id)
        {
            return db.Posiciones.Count(e => e.Id == id) > 0;
        }
    }
}