using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MercadoApp.Models
{
    public class SupermercadoContext : DbContext
    {
        public SupermercadoContext() : base("DefaultConnection") // Conexión a tu cadena de conexión
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

      
    }
}