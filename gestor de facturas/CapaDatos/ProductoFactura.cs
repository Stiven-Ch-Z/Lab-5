using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_facturas.CapaDatos
{
    public class ProductoFactura
    {
        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Subtotal
        {
            get { return Cantidad * Precio; }
        }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
