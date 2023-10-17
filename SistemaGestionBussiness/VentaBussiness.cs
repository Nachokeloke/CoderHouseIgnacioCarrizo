using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public static List<Venta> ListarVentaData()
        {
            return VentaData.ListarVentaData();
        }

        public static void EliminarVenta(int id)
        {
            VentaData.EliminarVentaData(id);
        }

        public static void CrearVenta(Venta venta)
        {
            VentaData.CrearVentaData(venta);
        }

        public static void ModificarVentaData(Venta ventaDataModificada)
        {
            VentaData.ModificarVentaData(ventaDataModificada);
        }

        public static void ObtenerVentaData(int id)
        {
            VentaData.ObtenerVentaData(id);
        }


    }
}