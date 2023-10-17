using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        
        
        [HttpGet(Name = "ObtenerProductoVendido")]
        public IEnumerable<ProductoVendido> Get()
        {
            return ProductoVendidoBussiness.ListarProductosVendidos().ToArray();
        }



        [HttpPut(Name = "ModificarProductoVendido")]
        public void Put( ProductoVendido productoVendidoModificado)
        {
            ProductoVendidoBussiness.ModificarProductoVendido( productoVendidoModificado);
        }


        [HttpDelete(Name = "EliminarProductoVendido")]

        public void Delete(int id)
        {
            ProductoVendidoBussiness.EliminarProductoVendido(id);
        }



        [HttpPost(Name = "CrearProductoVendido")]
        public void Post( ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.CrearProductoVendido(productoVendido);
        }
    }
}
