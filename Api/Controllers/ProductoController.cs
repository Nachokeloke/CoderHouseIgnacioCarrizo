using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class ProductoController : ControllerBase
    {
        
        [HttpGet(Name = "ObtenerProducto")]

        public IEnumerable<Producto> Get()


        {
            return ProductoBussiness.ListarProductos().ToArray();
        }
         

        [HttpPut(Name = "ModificarProducto")]

        public void Put(Producto productoModificado)
        {
            ProductoBussiness.ModificarProducto(productoModificado);  
        }




        [HttpDelete(Name = "EliminarProducto")]

        public void Delete(int id)
        {
            ProductoBussiness.EliminarProducto(id);
        }




        [HttpPost(Name = "CrearProducto")]
        public void Post(Producto producto)
        {
            ProductoBussiness.CrearProducto(producto);
        }



    }

}