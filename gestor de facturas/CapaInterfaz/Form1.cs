using gestor_de_facturas.CapaDatos;
using gestor_de_facturas.CapaLogica;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gestor_de_facturas
{
    public partial class Form1 : Form
    {
        private LogicaFactura logica = new LogicaFactura();
        private ErrorProvider errorProvider = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }

        //validacion de campos de errorprovider
        private bool ValidarCampos()
        {
            bool esvalido = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtnombre.Text)) //valida si el nombre esta vacio o no
            {
                errorProvider.SetError(txtnombre, "El nombre no puede quedar vacio");// si esta vacio el errorProvider da este mensaje 
                esvalido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtnombre.Text, @"^[a-zA-Z\s]+$"))
            {
                errorProvider.SetError(txtnombre, "El nombre solo puede tener letras ");// si esta vacio el errorProvider da este mensaje 
                esvalido = false;
            }
            if (!int.TryParse(txtcantidad.Text, out int cantidad) || cantidad <= 0)
            {
                errorProvider.SetError(txtcantidad, "La cantidad debe de ser un numero entero");// si se escribe una cantidad incorrecta muestra este mensaje de advertencia
                esvalido = false;
            }

            if (!decimal.TryParse(txtprecio.Text, out decimal precio) || precio <= 0)//valida que el precio sea el correcto
            {
                errorProvider.SetError(txtprecio, "El precio debe ser un numero y mayor a 0");// y este mensaje es el que muestra 
                esvalido = false;
            }
            return esvalido;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }
            ProductoFactura producto = new ProductoFactura
            {
                Nombre = txtnombre.Text,
                Cantidad = int.Parse(txtcantidad.Text),
                Precio = decimal.Parse(txtprecio.Text)

            };
            logica.AgregarProductos(producto);

            dgvproductos.DataSource = null;
            dgvproductos.DataSource = logica.ListaProductos;

            lbltotal.Text = "Total: " + logica.CalcularTotal().ToString("n2");
        }


        private void dgvproductos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvproductos.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0) //si se selecciona una linea en el datagrind
                {
                    dgvproductos.ClearSelection(); //se limpia esa linea
                    dgvproductos.Rows[hit.RowIndex].Selected = true;
                }
            }
        }

        private void eliminarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvproductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaseleccionada = dgvproductos.SelectedRows[0];
                int indice = filaseleccionada.Index;

                logica.ListaProductos.RemoveAt(indice);

                dgvproductos.DataSource = null;
                dgvproductos.DataSource = logica.ListaProductos;

                lbltotal.Text = "Total: " + logica.CalcularTotal().ToString("n2");
            }
        }
    }
}
