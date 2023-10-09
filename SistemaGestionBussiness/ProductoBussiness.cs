using SistemaGestionEntities;
using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness

{
    public class ProductoBussiness

    {
        public static List<Producto> ListarProductoss()

        { 
            return ProductoData.ListarProductos();
        }
        public static void EliminarProducto(int id)

        {
            ProductoData.EliminarProducto(id);
        }

        public static void CrearProducto(Producto producto)

        {
            ProductoData.CrearProducto(producto);
        }

        public static void ModificarProducto(int id, Producto productoModificado)

        {
            ProductoData.ModificarProducto(id, productoModificado);
        }

        public static Producto ObtenerProducto(int id)

        {
            return ProductoData.Obtenerproducto(id);
        }



    }

}

