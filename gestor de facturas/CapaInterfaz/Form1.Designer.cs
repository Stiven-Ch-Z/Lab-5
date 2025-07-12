namespace gestor_de_facturas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblnombre = new Label();
            lblcantidad = new Label();
            lblprecio = new Label();
            txtnombre = new TextBox();
            txtcantidad = new TextBox();
            txtprecio = new TextBox();
            dgvproductos = new DataGridView();
            btnagregar = new Button();
            lbltotal = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvproductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(126, 40);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(51, 15);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre";
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(122, 85);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(55, 15);
            lblcantidad.TabIndex = 1;
            lblcantidad.Text = "Cantidad";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(130, 130);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(40, 15);
            lblprecio.TabIndex = 2;
            lblprecio.Text = "Precio";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(208, 38);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(314, 23);
            txtnombre.TabIndex = 3;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(206, 82);
            txtcantidad.Margin = new Padding(3, 2, 3, 2);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(316, 23);
            txtcantidad.TabIndex = 4;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(206, 125);
            txtprecio.Margin = new Padding(3, 2, 3, 2);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(316, 23);
            txtprecio.TabIndex = 5;
            // 
            // dgvproductos
            // 
            dgvproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproductos.Location = new Point(77, 185);
            dgvproductos.Margin = new Padding(3, 2, 3, 2);
            dgvproductos.Name = "dgvproductos";
            dgvproductos.RowHeadersWidth = 51;
            dgvproductos.Size = new Size(542, 169);
            dgvproductos.TabIndex = 6;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(308, 159);
            btnagregar.Margin = new Padding(3, 2, 3, 2);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(82, 22);
            btnagregar.TabIndex = 7;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(526, 161);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(31, 15);
            lbltotal.TabIndex = 8;
            lbltotal.Text = "total";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(700, 363);
            Controls.Add(lbltotal);
            Controls.Add(btnagregar);
            Controls.Add(dgvproductos);
            Controls.Add(txtprecio);
            Controls.Add(txtcantidad);
            Controls.Add(txtnombre);
            Controls.Add(lblprecio);
            Controls.Add(lblcantidad);
            Controls.Add(lblnombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dgvproductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private Label lblcantidad;
        private Label lblprecio;
        private TextBox txtnombre;
        private TextBox txtcantidad;
        private TextBox txtprecio;
        private DataGridView dgvproductos;
        private Button btnagregar;
        private Label lbltotal;
        private ErrorProvider errorProvider1;
    }
}
