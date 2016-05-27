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

namespace Interview.Api.Controllers
{
    public class UsuariosController : ApiController
    {
        private SatrackDBEntities db = new SatrackDBEntities();

        /// <summary>
        /// Pemtire obtener los usuarios registrados en satrack
        /// </summary>
        /// <returns>Retorna una lista de objetos del tipo Usuario</returns>
        // GET: api/Usuarios
        public List<UsuarioDto> GetUsuarios()
        {
            return Data.Helpers.UsuarioHelper.GetUsuarios();
        }

        //// GET: api/Usuarios/5
        //[ResponseType(typeof(Usuarios))]
        //public async Task<IHttpActionResult> GetUsuarios(Guid id)
        //{
        //    Usuarios usuarios = await db.Usuarios.FindAsync(id);
        //    if (usuarios == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(usuarios);
        //}

        //// PUT: api/Usuarios/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutUsuarios(Guid id, Usuarios usuarios)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != usuarios.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(usuarios).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UsuariosExists(id))
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

        //// POST: api/Usuarios
        //[ResponseType(typeof(Usuarios))]
        //public async Task<IHttpActionResult> PostUsuarios(Usuarios usuarios)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Usuarios.Add(usuarios);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (UsuariosExists(usuarios.Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = usuarios.Id }, usuarios);
        //}

        //// DELETE: api/Usuarios/5
        //[ResponseType(typeof(Usuarios))]
        //public async Task<IHttpActionResult> DeleteUsuarios(Guid id)
        //{
        //    Usuarios usuarios = await db.Usuarios.FindAsync(id);
        //    if (usuarios == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Usuarios.Remove(usuarios);
        //    await db.SaveChangesAsync();

        //    return Ok(usuarios);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsuariosExists(Guid id)
        {
            return db.Usuarios.Count(e => e.Id == id) > 0;
        }
    }
}