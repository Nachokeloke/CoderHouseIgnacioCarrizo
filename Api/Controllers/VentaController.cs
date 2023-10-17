using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "ObtenerVenta")]
        public IEnumerable<Venta> Get()
        {
            return VentaBussiness.ListarVentaData().ToArray();
        }

        [HttpPut(Name = "ModificarVenta")]
        public void Put( Venta ventaModificada)
        {
            VentaBussiness.ModificarVentaData( ventaModificada);
        }


        [HttpDelete(Name = "EliminarVenta")]
        
        public void Delete(int id)
        {
            VentaBussiness.EliminarVenta(id);
        }
        
  
        [HttpPost(Name = "CrearVenta")]
        public void Post(Venta venta)
        {
            VentaBussiness.CrearVenta(venta);
        }
    }
}
