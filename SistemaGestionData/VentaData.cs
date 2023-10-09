using SistemaGestionEntities;
using SistemaGestionBussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData

{
    public class VentaData

    {
        public static Venta ObtenerVentaData(int id)
        {
            try
            { 
            using (var context = new SistemaGestionContext())
            {
                return context.Ventas.FirstOrDefault(v => v.id == id);

            }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el producto: " +ex.Message);

                return null;

            }
        }

        public static List<Venta> ListarVentaData ()


        {
            try
            { 
            using (var context = new SistemaGestionContext())
            {
                return context.Ventas.ToList();
            }
            }

            catch (Exception ex)

            { 
                Console.WriteLine("Error al obtener el producto" + ex.Message);

                return null;
            }
        }

        public static void CrearVentaData(Venta ventaData)

        {
            try
            { 
            using (var context = new SistemaGestionContext())
            {
                context.Ventas.Add(ventaData);
                context.SaveChanges();
            }
        }
            catch (Exception ex)

            {
                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;

            }
         }

        public static void EliminarVentaData(int id)
        {
            try
            { 

            using (var context = new SistemaGestionContext())
            {
                var ventaDataExistente = context.Ventas.FirstOrDefault(v => v.id == id);
                if (ventaDataExistente == null) ;
                {
                    context.Ventas.Remove(ventaDataExistente);
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
            

        public static void ModificarVentaData(int id, Venta ventaDataModificada)
        {
            try

            { 
            using (var context = new SistemaGestionContext())
            {
                var ventaDataExistente = context.Ventas.FirstOrDefault(v => v.id == id);
                if (ventaDataExistente == null)
                {
                    ventaDataExistente.id = ventaDataModificada.id;
                    ventaDataExistente.IdUsuario = ventaDataModificada.IdUsuario;
                    ventaDataExistente.Comentarios = ventaDataModificada.Comentarios;
                }
            }

        }

            catch (Exception ex) 
            
            { 
                
                Console.WriteLine("Error al obtener el producto: "+ ex.Message);
                
                return;
            
            }
    }
}
}

