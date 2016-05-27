using Interview.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Data.Helpers
{
    public static class UsuarioHelper
    {


        public static List<Models.Entities.UsuarioDto> GetUsuarios()
        {
            SatrackDBEntities db = new SatrackDBEntities();

            var result = new List<Models.Entities.UsuarioDto>();

            var users = db.Usuarios.ToList();

            foreach (var item in users)
            {
                result.Add(
                        new Models.Entities.UsuarioDto
                        {
                            Id = item.Id,
                            Nombre = item.Nombre,
                            Usuario = item.Usuario
                        }
                    );
            }


            return result;
        }
    }
}
