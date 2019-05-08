namespace Pizzas
{
    partial class FrmProducto
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.productoTableAdapter = new Pizzas.pizzasDataSetTableAdapters.productoTableAdapter();
            this.PanelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelEspecialidad = new System.Windows.Forms.FlowLayoutPanel();
            this.pizzasDataSet = new Pizzas.pizzasDataSet();
            this.producto_especialidadTableAdapter = new Pizzas.pizzasDataSetTableAdapters.producto_especialidadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Image = global::Pizzas.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(154, 330);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 100);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Black;
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptar.Image = global::Pizzas.Properties.Resources.Aceptar;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(13, 330);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 100);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // PanelProductos
            // 
            this.PanelProductos.AutoScroll = true;
            this.PanelProductos.BackColor = System.Drawing.Color.Transparent;
            this.PanelProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelProductos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelProductos.Location = new System.Drawing.Point(1, 4);
            this.PanelProductos.Name = "PanelProductos";
            this.PanelProductos.Size = new System.Drawing.Size(301, 305);
            this.PanelProductos.TabIndex = 0;
            this.PanelProductos.WrapContents = false;
            // 
            // PanelEspecialidad
            // 
            this.PanelEspecialidad.AutoScroll = true;
            this.PanelEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.PanelEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelEspecialidad.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelEspecialidad.Location = new System.Drawing.Point(332, 4);
            this.PanelEspecialidad.Name = "PanelEspecialidad";
            this.PanelEspecialidad.Size = new System.Drawing.Size(320, 418);
            this.PanelEspecialidad.TabIndex = 9;
            this.PanelEspecialidad.WrapContents = false;
            // 
            // pizzasDataSet
            // 
            this.pizzasDataSet.DataSetName = "pizzasDataSet";
            this.pizzasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producto_especialidadTableAdapter
            // 
            this.producto_especialidadTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizzas.Properties.Resources.Fondo_Papel_Viejo;
            this.ClientSize = new System.Drawing.Size(305, 434);
            this.Controls.Add(this.PanelEspecialidad);
            this.Controls.Add(this.PanelProductos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmAlgoMas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizzasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private pizzasDataSetTableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel PanelProductos;
        private System.Windows.Forms.FlowLayoutPanel PanelEspecialidad;
        private pizzasDataSet pizzasDataSet;
        private pizzasDataSetTableAdapters.producto_especialidadTableAdapter producto_especialidadTableAdapter;

    }
}