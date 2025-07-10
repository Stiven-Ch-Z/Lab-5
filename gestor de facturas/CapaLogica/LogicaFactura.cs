using gestor_de_facturas.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_facturas.CapaLogica
{
    public class LogicaFactura
    {
        public List<ProductoFactura> ListaProductos {  get; set; } =new List<ProductoFactura>();

        public void AgregarProductos(ProductoFactura producto)
        {
            ListaProductos.Add(producto);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in ListaProductos)
            {
                total += item.Subtotal;
            }
            return total;
        }
    }
}
