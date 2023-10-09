using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using SistemaGestionData;
using Microsoft.EntityFrameworkCore; 

namespace SistemaGestionBussiness
{
    public class SistemaGestionContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ProductoVendido> ProductosVendidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=SistemaGestionEF3;Trusted_Connection=True");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}