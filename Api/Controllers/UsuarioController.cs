using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        [HttpGet(Name = "ObtenerUsuarios")]
        public IEnumerable<Usuario> Get()

        {
            return UsuarioBussiness.ListarUsuario().ToArray();
        }



        [HttpPut(Name = "ModificarUsuario")]

        public void Put(Usuario usuarioModificado)
        {
            UsuarioBussiness.ModificarUsuario(usuarioModificado);
        }


        [HttpDelete(Name = "EliminarUsuario")]

        public void Delete(int id)
        {
            UsuarioBussiness.EliminarUsuario(id);
        }




        [HttpPost(Name = "CrearUsuario")]
        public void Post(Usuario usuario)
        {
            UsuarioBussiness.CrearUsuario(usuario);
        }

        [HttpPost, Route("Validarloguin")]
        public bool Login(UsuarioLogin usuarioLogin)
        {
            return UsuarioBussiness.Validarloguin(usuarioLogin);
        }
    }
}
