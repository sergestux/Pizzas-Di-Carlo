namespace Pizzas
{
    partial class FrmOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrden));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.btnOrdenStatus = new System.Windows.Forms.Button();
            this.btnOrdenNumero = new System.Windows.Forms.Button();
            this.btnOrdenFecha = new System.Windows.Forms.Button();
            this.btnOrdenUsuario = new System.Windows.Forms.Button();
            this.groupCliente = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgOrdenDetalle = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pizzasDataSet = new Pizzas.pizzasDataSet();
            this.clienteTableAdapter = new Pizzas.pizzasDataSetTableAdapters.clienteTableAdapter();
            this.orden_detalleTableAdapter = new Pizzas.pizzasDataSetTableAdapters.orden_detalleTableAdapter();
            this.ordenTableAdapter = new Pizzas.pizzasDataSetTableAdapters.ordenTableAdapter();
            this.orden_detalladaTableAdapter = new Pizzas.pizzasDataSetTableAdapters.orden_detalladaTableAdapter();
            this.BtnAlgoMas = new System.Windows.Forms.Button();
            this.BtnPizzas = new System.Windows.Forms.Button();
            this.BtnBebidas = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.btnReimprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nothing You Could Say", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Nothing You Could Say", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(88, 21);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(141, 29);
            this.txtTelefono.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nothing You Could Say", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Nothing You Could Say", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(412, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Pizzas.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(357, 590);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 83);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.Black;
            this.btnCobrar.FlatAppearance.BorderSize = 2;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Image = global::Pizzas.Properties.Resources.Aceptar;
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCobrar.Location = new System.Drawing.Point(7, 590);
            this.btnCobrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(120, 83);
            this.btnCobrar.TabIndex = 4;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pizzas.Properties.Resources.Division;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 573);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 10);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Nothing You Could Say", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(4, 57);
            this.lblDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(58, 22);
            this.lblDomicilio.TabIndex = 2;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Font = new System.Drawing.Font("Nothing You Could Say", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(88, 54);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(573, 50);
            this.txtDomicilio.TabIndex = 8;
            this.txtDomicilio.Text = resources.GetString("txtDomicilio.Text");
            // 
            // btnOrdenStatus
            // 
            this.btnOrdenStatus.BackColor = System.Drawing.Color.Black;
            this.btnOrdenStatus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrdenStatus.FlatAppearance.BorderSize = 2;
            this.btnOrdenStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenStatus.Font = new System.Drawing.Font("Nothing You Could Say", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenStatus.Image = global::Pizzas.Properties.Resources.Orden_Status;
            this.btnOrdenStatus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrdenStatus.Location = new System.Drawing.Point(182, 1);
            this.btnOrdenStatus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrdenStatus.Name = "btnOrdenStatus";
            this.btnOrdenStatus.Size = new System.Drawing.Size(180, 58);
            this.btnOrdenStatus.TabIndex = 10;
            this.btnOrdenStatus.Text = "Status";
            this.btnOrdenStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdenStatus.UseVisualStyleBackColor = false;
            // 
            // btnOrdenNumero
            // 
            this.btnOrdenNumero.BackColor = System.Drawing.Color.Black;
            this.btnOrdenNumero.FlatAppearance.BorderSize = 2;
            this.btnOrdenNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenNumero.Font = new System.Drawing.Font("Nothing You Could Say", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenNumero.Image = global::Pizzas.Properties.Resources.Orden_Numero;
            this.btnOrdenNumero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrdenNumero.Location = new System.Drawing.Point(1, 1);
            this.btnOrdenNumero.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrdenNumero.Name = "btnOrdenNumero";
            this.btnOrdenNumero.Size = new System.Drawing.Size(180, 58);
            this.btnOrdenNumero.TabIndex = 9;
            this.btnOrdenNumero.Text = "Orden: ";
            this.btnOrdenNumero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdenNumero.UseVisualStyleBackColor = false;
            // 
            // btnOrdenFecha
            // 
            this.btnOrdenFecha.BackColor = System.Drawing.Color.Black;
            this.btnOrdenFecha.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrdenFecha.FlatAppearance.BorderSize = 2;
            this.btnOrdenFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenFecha.Font = new System.Drawing.Font("Nothing You Could Say", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenFecha.Image = global::Pizzas.Properties.Resources.Orden_Fecha;
            this.btnOrdenFecha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrdenFecha.Location = new System.Drawing.Point(362, 1);
            this.btnOrdenFecha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrdenFecha.Name = "btnOrdenFecha";
            this.btnOrdenFecha.Size = new System.Drawing.Size(180, 58);
            this.btnOrdenFecha.TabIndex = 11;
            this.btnOrdenFecha.Text = "Fecha";
            this.btnOrdenFecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdenFecha.UseVisualStyleBackColor = false;
            // 
            // btnOrdenUsuario
            // 
            this.btnOrdenUsuario.BackColor = System.Drawing.Color.Black;
            this.btnOrdenUsuario.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrdenUsuario.FlatAppearance.BorderSize = 2;
            this.btnOrdenUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenUsuario.Font = new System.Drawing.Font("Nothing You Could Say", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenUsuario.Image = global::Pizzas.Properties.Resources.Orden_Usuario;
            this.btnOrdenUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrdenUsuario.Location = new System.Drawing.Point(543, 1);
            this.btnOrdenUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrdenUsuario.Name = "btnOrdenUsuario";
            this.btnOrdenUsuario.Size = new System.Drawing.Size(180, 58);
            this.btnOrdenUsuario.TabIndex = 12;
            this.btnOrdenUsuario.Text = "Usuario";
            this.btnOrdenUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdenUsuario.UseVisualStyleBackColor = false;
            // 
            // groupCliente
            // 
            this.groupCliente.BackColor = System.Drawing.Color.Black;
            this.groupCliente.Controls.Add(this.label1);
            this.groupCliente.Controls.Add(this.txtTelefono);
            this.groupCliente.Controls.Add(this.label2);
            this.groupCliente.Controls.Add(this.lblDomicilio);
            this.groupCliente.Controls.Add(this.txtNombre);
            this.groupCliente.Controls.Add(this.txtDomicilio);
            this.groupCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(194)))), ((int)(((byte)(145)))));
            this.groupCliente.Location = new System.Drawing.Point(-1, 64);
            this.groupCliente.Name = "groupCliente";
            this.groupCliente.Size = new System.Drawing.Size(697, 119);
            this.groupCliente.TabIndex = 14;
            this.groupCliente.TabStop = false;
            this.groupCliente.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Nothing You Could Say", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(552, 205);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(52, 29);
            this.txtCantidad.TabIndex = 20;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TecladoNumerico);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(12, 241);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(0, 26);
            this.lblProducto.TabIndex = 9;
            // 
            // dgOrdenDetalle
            // 
            this.dgOrdenDetalle.AllowUserToAddRows = false;
            this.dgOrdenDetalle.AllowUserToResizeColumns = false;
            this.dgOrdenDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.NullValue = null;
            this.dgOrdenDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrdenDetalle.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgOrdenDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdenDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.producto_id,
            this.especialidad_id,
            this.Cantidad,
            this.Descripcion,
            this.ImporteU,
            this.Total,
            this.Status});
            this.dgOrdenDetalle.Location = new System.Drawing.Point(7, 275);
            this.dgOrdenDetalle.MultiSelect = false;
            this.dgOrdenDetalle.Name = "dgOrdenDetalle";
            this.dgOrdenDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgOrdenDetalle.RowHeadersVisible = false;
            this.dgOrdenDetalle.RowHeadersWidth = 30;
            this.dgOrdenDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgOrdenDetalle.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(194)))), ((int)(((byte)(145)))));
            this.dgOrdenDetalle.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.dgOrdenDetalle.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgOrdenDetalle.RowTemplate.Height = 50;
            this.dgOrdenDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgOrdenDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrdenDetalle.ShowEditingIcon = false;
            this.dgOrdenDetalle.Size = new System.Drawing.Size(723, 254);
            this.dgOrdenDetalle.TabIndex = 21;
            this.dgOrdenDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrdenDetalle_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // producto_id
            // 
            this.producto_id.HeaderText = "producto_id";
            this.producto_id.Name = "producto_id";
            this.producto_id.Visible = false;
            // 
            // especialidad_id
            // 
            this.especialidad_id.HeaderText = "especialidad_id";
            this.especialidad_id.Name = "especialidad_id";
            this.especialidad_id.Visible = false;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.ToolTipText = "Cantidad";
            this.Cantidad.Width = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Producto";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.ToolTipText = "Descripcion del producto";
            this.Descripcion.Width = 350;
            // 
            // ImporteU
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ImporteU.DefaultCellStyle = dataGridViewCellStyle3;
            this.ImporteU.HeaderText = "Precio U.";
            this.ImporteU.Name = "ImporteU";
            this.ImporteU.ReadOnly = true;
            this.ImporteU.ToolTipText = "Precio Unitario";
            // 
            // Total
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.ToolTipText = "Precio Unitario x Cantidad";
            this.Total.Width = 110;
            // 
            // Status
            // 
            this.Status.FalseValue = "0";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.TrueValue = "1";
            this.Status.Width = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(85, 537);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(96, 33);
            this.txtSubtotal.TabIndex = 23;
            this.txtSubtotal.Text = "0";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.FormatearMoneda);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(328, 534);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(83, 33);
            this.txtDescuento.TabIndex = 23;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TecladoNumerico);
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(555, 531);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(116, 33);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TecladoNumerico);
            this.txtTotal.TextChanged += new System.EventHandler(this.FormatearMoneda);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Pizzas.Properties.Resources.Salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(532, 590);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 83);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // pizzasDataSet
            // 
            this.pizzasDataSet.DataSetName = "pizzasDataSet";
            this.pizzasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // orden_detalleTableAdapter
            // 
            this.orden_detalleTableAdapter.ClearBeforeFill = true;
            // 
            // ordenTableAdapter
            // 
            this.ordenTableAdapter.ClearBeforeFill = true;
            // 
            // orden_detalladaTableAdapter
            // 
            this.orden_detalladaTableAdapter.ClearBeforeFill = true;
            // 
            // BtnAlgoMas
            // 
            this.BtnAlgoMas.BackColor = System.Drawing.Color.Black;
            this.BtnAlgoMas.BackgroundImage = global::Pizzas.Properties.Resources.Algo_Mas;
            this.BtnAlgoMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAlgoMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlgoMas.Location = new System.Drawing.Point(303, 188);
            this.BtnAlgoMas.Name = "BtnAlgoMas";
            this.BtnAlgoMas.Size = new System.Drawing.Size(101, 46);
            this.BtnAlgoMas.TabIndex = 24;
            this.BtnAlgoMas.Text = "Algo mas...?";
            this.BtnAlgoMas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAlgoMas.UseVisualStyleBackColor = false;
            this.BtnAlgoMas.Click += new System.EventHandler(this.btnAlgoMas_Click);
            // 
            // BtnPizzas
            // 
            this.BtnPizzas.BackColor = System.Drawing.Color.Black;
            this.BtnPizzas.BackgroundImage = global::Pizzas.Properties.Resources.Pizzas;
            this.BtnPizzas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPizzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPizzas.Location = new System.Drawing.Point(21, 188);
            this.BtnPizzas.Name = "BtnPizzas";
            this.BtnPizzas.Size = new System.Drawing.Size(101, 46);
            this.BtnPizzas.TabIndex = 25;
            this.BtnPizzas.Text = "Pizzas";
            this.BtnPizzas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPizzas.UseVisualStyleBackColor = false;
            this.BtnPizzas.Click += new System.EventHandler(this.BtnPizzas_Click);
            // 
            // BtnBebidas
            // 
            this.BtnBebidas.BackColor = System.Drawing.Color.Black;
            this.BtnBebidas.BackgroundImage = global::Pizzas.Properties.Resources.Bebidas;
            this.BtnBebidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBebidas.Location = new System.Drawing.Point(162, 188);
            this.BtnBebidas.Name = "BtnBebidas";
            this.BtnBebidas.Size = new System.Drawing.Size(101, 46);
            this.BtnBebidas.TabIndex = 26;
            this.BtnBebidas.Text = "Bebidas";
            this.BtnBebidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBebidas.UseVisualStyleBackColor = false;
            this.BtnBebidas.Click += new System.EventHandler(this.BtnBebidas_Click);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.Black;
            this.BtnAgregarProducto.BackgroundImage = global::Pizzas.Properties.Resources.Agregar;
            this.BtnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(632, 189);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(79, 45);
            this.BtnAgregarProducto.TabIndex = 27;
            this.BtnAgregarProducto.Text = "Agregar";
            this.BtnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.BackColor = System.Drawing.Color.Black;
            this.btnReimprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReimprimir.Enabled = false;
            this.btnReimprimir.FlatAppearance.BorderSize = 2;
            this.btnReimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReimprimir.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprimir.Image = global::Pizzas.Properties.Resources.Imprimir;
            this.btnReimprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReimprimir.Location = new System.Drawing.Point(182, 590);
            this.btnReimprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(120, 83);
            this.btnReimprimir.TabIndex = 4;
            this.btnReimprimir.Text = "ReImprimir";
            this.btnReimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReimprimir.UseVisualStyleBackColor = false;
            this.btnReimprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(91)))), ((int)(((byte)(67)))));
            this.BackgroundImage = global::Pizzas.Properties.Resources.Fondo_Papel_Viejo;
            this.ClientSize = new System.Drawing.Size(744, 682);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.BtnBebidas);
            this.Controls.Add(this.BtnPizzas);
            this.Controls.Add(this.BtnAlgoMas);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgOrdenDetalle);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupCliente);
            this.Controls.Add(this.btnOrdenUsuario);
            this.Controls.Add(this.btnOrdenFecha);
            this.Controls.Add(this.btnOrdenStatus);
            this.Controls.Add(this.btnOrdenNumero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReimprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Font = new System.Drawing.Font("Nothing You Could Say", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrandose);
            this.Load += new System.EventHandler(this.FrmOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupCliente.ResumeLayout(false);
            this.groupCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Button btnOrdenStatus;
        private System.Windows.Forms.Button btnOrdenNumero;
        private System.Windows.Forms.Button btnOrdenFecha;
        private System.Windows.Forms.Button btnOrdenUsuario;
        private System.Windows.Forms.GroupBox groupCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dgOrdenDetalle;
        private pizzasDataSet pizzasDataSet;
        private pizzasDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private pizzasDataSetTableAdapters.orden_detalleTableAdapter orden_detalleTableAdapter;
        private pizzasDataSetTableAdapters.ordenTableAdapter ordenTableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private pizzasDataSetTableAdapters.orden_detalladaTableAdapter orden_detalladaTableAdapter;
        private System.Windows.Forms.Button BtnAlgoMas;
        private System.Windows.Forms.Button BtnPizzas;
        private System.Windows.Forms.Button BtnBebidas;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.Button btnReimprimir;
    }
}