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
            lblnombre = new Label();
            lblcantidad = new Label();
            lblprecio = new Label();
            txtnombre = new TextBox();
            txtcantidad = new TextBox();
            txtprecio = new TextBox();
            dgvproductos = new DataGridView();
            btnagregar = new Button();
            lbltotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvproductos).BeginInit();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(144, 54);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(64, 20);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre";
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(139, 113);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(69, 20);
            lblcantidad.TabIndex = 1;
            lblcantidad.Text = "Cantidad";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(148, 174);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(50, 20);
            lblprecio.TabIndex = 2;
            lblprecio.Text = "Precio";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(238, 51);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(358, 27);
            txtnombre.TabIndex = 3;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(236, 110);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(360, 27);
            txtcantidad.TabIndex = 4;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(236, 167);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(360, 27);
            txtprecio.TabIndex = 5;
            // 
            // dgvproductos
            // 
            dgvproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproductos.Location = new Point(88, 247);
            dgvproductos.Name = "dgvproductos";
            dgvproductos.RowHeadersWidth = 51;
            dgvproductos.Size = new Size(619, 225);
            dgvproductos.TabIndex = 6;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(352, 212);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(94, 29);
            btnagregar.TabIndex = 7;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(601, 215);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(40, 20);
            lbltotal.TabIndex = 8;
            lbltotal.Text = "total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 484);
            Controls.Add(lbltotal);
            Controls.Add(btnagregar);
            Controls.Add(dgvproductos);
            Controls.Add(txtprecio);
            Controls.Add(txtcantidad);
            Controls.Add(txtnombre);
            Controls.Add(lblprecio);
            Controls.Add(lblcantidad);
            Controls.Add(lblnombre);
            Name = "Form1";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dgvproductos).EndInit();
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
    }
}
