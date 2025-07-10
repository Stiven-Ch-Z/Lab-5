using gestor_de_facturas.CapaDatos;
using gestor_de_facturas.CapaLogica;

namespace gestor_de_facturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private LogicaFactura logica = new LogicaFactura();

        private void btnagregar_Click(object sender, EventArgs e)
        {
            ProductoFactura producto = new ProductoFactura
            {
                Nombre = txtnombre.Text,
                Cantidad =int.Parse(txtcantidad.Text),
                Precio = decimal.Parse(txtprecio.Text)

            };
            logica.AgregarProductos(producto);

            dgvproductos.DataSource = null;
            dgvproductos.DataSource = logica.ListaProductos;

            lbltotal.Text= "Total: "+ logica.CalcularTotal().ToString("n2");
        }
    }
}
