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
            ctmproductos = new ContextMenuStrip(components);
            eliminarFilaToolStripMenuItem = new ToolStripMenuItem();
            btnagregar = new Button();
            lbltotal = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvproductos).BeginInit();
            ctmproductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(144, 53);
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
            lblprecio.Location = new Point(149, 173);
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
            txtcantidad.Location = new Point(235, 109);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(361, 27);
            txtcantidad.TabIndex = 4;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(235, 167);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(361, 27);
            txtprecio.TabIndex = 5;
            // 
            // dgvproductos
            // 
            dgvproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproductos.ContextMenuStrip = ctmproductos;
            dgvproductos.Location = new Point(88, 247);
            dgvproductos.Name = "dgvproductos";
            dgvproductos.RowHeadersWidth = 51;
            dgvproductos.Size = new Size(619, 225);
            dgvproductos.TabIndex = 6;
            // 
            // ctmproductos
            // 
            ctmproductos.ImageScalingSize = new Size(20, 20);
            ctmproductos.Items.AddRange(new ToolStripItem[] { eliminarFilaToolStripMenuItem });
            ctmproductos.Name = "ctmproductos";
            ctmproductos.Size = new Size(211, 56);
            // 
            // eliminarFilaToolStripMenuItem
            // 
            eliminarFilaToolStripMenuItem.Name = "eliminarFilaToolStripMenuItem";
            eliminarFilaToolStripMenuItem.Size = new Size(210, 24);
            eliminarFilaToolStripMenuItem.Text = "Eliminar fila";
            eliminarFilaToolStripMenuItem.Click += eliminarFilaToolStripMenuItem_Click;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            ctmproductos.ResumeLayout(false);
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
        private ContextMenuStrip ctmproductos;
        private ToolStripMenuItem eliminarFilaToolStripMenuItem;
    }
}
