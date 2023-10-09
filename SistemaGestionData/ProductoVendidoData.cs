using SistemaGestionEntities;
using SistemaGestionBussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaGestionData

{
    public class ProductoVendidoData
    {
        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {

            try 
            {
                using (var context = new SistemaGestionContext())
                
               {
                    context.ProductosVendidos.Add(productoVendido);
                    context.SaveChanges();
                }
                
            }


            catch (Exception ex )
 
            {

               
                Console.WriteLine(ex.Message);

                return;
            }
        
        
        }


        public static ProductoVendido ObtenerProductoVendido(int id)

        {
            try
            {
                using (var context = new SistemaGestionContext())
            {
                return context.ProductosVendidos.FirstOrDefault(pv => pv.Id == id);
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error al obtener el producto: "+ ex.Message);

                return null;
            }
         }

        public static List<ProductoVendido> GetProductoVendidos()
        {
            try
            {

                using (var context = new SistemaGestionContext())
                {
                    return context.ProductosVendidos.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return null;
            }

        }

        public static void CrearProductoVendidos(ProductoVendido productoVendido)

        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    context.ProductosVendidos.Add(productoVendido);
                    context.SaveChanges();

                }
            }

            catch (Exception ex)

            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;

            }

        }
        public static void EliminarProductoVendido(int id)

        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    var productoVendidoExistente = context.ProductosVendidos.FirstOrDefault(pv => pv.Id == id);
                    if (productoVendidoExistente == null)
                    {
                        context.ProductosVendidos.Remove(productoVendidoExistente);
                        context.SaveChanges();

                    }
                }

            }

            catch (Exception ex)

            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;

            }
        }

        public static void ModificarProductoVendido(int id, ProductoVendido productoVendidoModificado)

        {
            try

            {
                using (var context = new SistemaGestionContext())
                {
                    var productoVendidoExistente = context.ProductosVendidos.FirstOrDefault(pv => pv.Id == id);
                    if (productoVendidoExistente == null)
                    {
                        productoVendidoExistente.Id = productoVendidoExistente.Id;
                        productoVendidoExistente.IdProducto = productoVendidoExistente.IdProducto;
                        productoVendidoExistente.Stock = productoVendidoExistente.Stock;
                        productoVendidoExistente.IdVenta = productoVendidoExistente.IdVenta;

                        context.SaveChanges();
                    }
                }

            }
            catch (Exception ex)

            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;
            }

        }

    }



}
