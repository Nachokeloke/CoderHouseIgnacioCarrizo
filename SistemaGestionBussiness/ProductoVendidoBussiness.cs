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
            public static List <ProductoVendido> GetProductoVendidos()

        {
            return ProductoVendidoData.GetProductoVendidos();

        }

        public static void EliminarProductoVendido (int id )
        {
            ProductoVendidoData.ObtenerProductoVendido ( id );
        }

        
          public static void ObtenerProductoVendido (int id)
        {
            ProductoVendidoData.ObtenerProductoVendido( id );
        }


        public static void ModificarProductoVendido ( int id, ProductoVendido productoVendidoModificado )
        {
            ProductoVendidoData.ModificarProductoVendido(id, productoVendidoModificado);
        }

        public static void CrearProductoVendidos (ProductoVendido productoVendido)
        {

            ProductoVendidoData.CrearProductoVendidos (productoVendido);

        }


    }

}
