using SistemaGestionEntities;
using SistemaGestionBussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;



namespace SistemaGestionData

{
    public static class ProductoData

    {
        public static Producto Obtenerproducto(int Id)
        {
            try
            {
                using (var context = new SistemaGestionContext())
            {
                return context.Productos.FirstOrDefault(p => p.Id == Id);

            }
        }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return null;
            }

        }
        public static List<Producto> ListarProductos()

        {
            try 

            {
                using (var context = new SistemaGestionContext())
            {
                return context.Productos.ToList();
            }

            }
            
            catch (Exception ex)
            { Console.WriteLine("Error al listar el obtener el producto: " +ex.Message);

                return null;

            }



        }
            
            public static void CrearProducto(Producto producto)

        {
            try
            {
                using (var context = new SistemaGestionContext())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }

            }
             
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;
            }
        }

        public static void EliminarProducto(int Id)

        {
            try
            {

            
            using (var context = new SistemaGestionContext())

            {
                var productoExistente = context.Productos.FirstOrDefault(p => p.Id == Id);
                if (productoExistente != null)

                {

                    context.Productos.Remove(productoExistente);

                    context.SaveChanges();
                }
            }

            }
            catch (Exception ex) 
            
            {
                Console.WriteLine("Error al obtener el producto: "+ ex.Message);

                return;
            }

            }

    
    
        public static void ModificarProducto( Producto productoModificado)

        {
        try
        { 
            using (var context = new SistemaGestionContext())
            {
                var productoExistente = context.Productos.FirstOrDefault(p => p.Id == productoModificado.Id);
                if (productoExistente == null)
                {
                    productoExistente.Descripciones = productoModificado.Descripciones;
                    productoExistente.Costo = productoModificado.Costo;
                    productoExistente.PrecioVenta = productoModificado.PrecioVenta;
                    productoExistente.Stock = productoModificado.Stock;
                    productoExistente.IdUsuario = productoModificado.IdUsuario;

                    context.SaveChanges();

                }
            }
        

     
        }

        catch (Exception ex)
        {


            Console.WriteLine("Error al obtener el producto " + ex.Message);


         }
    }
    }
}


