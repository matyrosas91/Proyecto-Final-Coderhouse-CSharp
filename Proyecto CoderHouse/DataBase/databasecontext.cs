using Microsoft.EntityFrameworkCore;
using Proyecto_CoderHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CoderHouse.DataBase
{
    public class databasecontext : DbContext
    {
        public DbSet<Producto>? Productos { get; set; }
        internal DbSet<Usuario>? Usuarios{ get; set; }
        internal DbSet<ProductoVendido>? ProductoVendidos {  get; set; }
        internal DbSet<Venta>? Venta {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(connectionString: "Server=localhost\\SQLEXPRESS; Database=coderhouse; Trusted_Connection=True");
        }
    }
}