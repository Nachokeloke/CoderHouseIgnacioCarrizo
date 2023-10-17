using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
        {
            public static List <ProductoVendido> ListarProductosVendidos()

        {
            return ProductoVendidoData.ListarProductosVendidos();

        }

        public static void EliminarProductoVendido (int id )
        {
            ProductoVendidoData.EliminarProductoVendido( id );
        }

        
          public static void ObtenerProductoVendido (int id)
        {
            ProductoVendidoData.ObtenerProductoVendido( id );
        }


        public static void ModificarProductoVendido ( ProductoVendido productoVendidoModificado )
        {
            ProductoVendidoData.ModificarProductoVendido( productoVendidoModificado);
        }

        public static void CrearProductoVendido (ProductoVendido productoVendido)
        {

            ProductoVendidoData.CrearProductoVendido (productoVendido);

        }


    }

}
