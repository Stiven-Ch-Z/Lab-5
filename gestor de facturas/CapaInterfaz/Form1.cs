using gestor_de_facturas.CapaDatos;
using gestor_de_facturas.CapaLogica;

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
                errorProvider.SetError(txtnombre, "!!!El nombre no puede quedar vacio!!!");// si esta vacio el errorProvider da este mensaje 
                esvalido = false;
            }
            
             if (string.IsNullOrWhiteSpace(txtcantidad.Text))//  valida si la cantidad se encuentra vacia
            {
                errorProvider.SetError(txtcantidad, "!!!La cantidad no puede quedar vacia!!!");// muestra este mensaje de advertencia si se encuentra vacia
                esvalido = false;
            }
            else
            {
                //valida que la cantidad sea correcta
                if (!int.TryParse(txtcantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    errorProvider.SetError(txtcantidad, "!!!La cantidad debe de ser un numero entero!!!");// si se escribe una cantidad incorrecta muestra este mensaje de advertencia
                    esvalido = false;
                }

            }
            if (string.IsNullOrWhiteSpace(txtprecio.Text))//valida que el precio no este vacio
            {
                errorProvider.SetError(txtprecio, "!!!El precio no puede quedar vacio!!!");// y si lo esta da este mensaje de advertencia
                esvalido = false;
            }
            else
            {
                if (!decimal.TryParse(txtprecio.Text, out decimal precio) || precio<= 0)//valida que el precio sea el correcto
                {
                    errorProvider.SetError(txtprecio, "!!!El precio debe de ser mayor a 0!!!");// y este mensaje es el que muestra 
                    esvalido = false;
                }   

            }
            return esvalido;        
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if(!ValidarCampos())
            {
                return;
            }
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
