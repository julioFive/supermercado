namespace MercadoApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MercadoApp.Models; // Asegúrate de incluir el espacio de nombres correcto

    internal sealed class Configuration : DbMigrationsConfiguration<SupermercadoContext> // Cambia a tu contexto
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false; // Puedes dejar esto como false
            ContextKey = "MercadoApp.Models.SupermercadoContext"; // Actualiza la clave del contexto
        }

        protected override void Seed(SupermercadoContext context)
        {
            // Este método se llamará después de migrar a la versión más reciente.
            // Puedes usar el método DbSet<T>.AddOrUpdate() para evitar crear datos duplicados.
        }
    }
}
