using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MercadoApp.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}