namespace Pizzas
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerMesas = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnCorteCaja = new System.Windows.Forms.Button();
            this.btnCatalogos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.Black;
            this.btnVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenta.FlatAppearance.BorderSize = 2;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVenta.Image = global::Pizzas.Properties.Resources.Venta;
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVenta.Location = new System.Drawing.Point(0, 0);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(356, 100);
            this.btnVenta.TabIndex = 5;
            this.btnVenta.Text = "Venta";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Image = global::Pizzas.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(0, 546);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(356, 91);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pizzas.Properties.Resources.Division;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 536);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 10);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerMesas
            // 
            this.btnVerMesas.BackColor = System.Drawing.Color.Black;
            this.btnVerMesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerMesas.FlatAppearance.BorderSize = 2;
            this.btnVerMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMesas.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMesas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerMesas.Image = global::Pizzas.Properties.Resources.MesasOcupadas;
            this.btnVerMesas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerMesas.Location = new System.Drawing.Point(0, 100);
            this.btnVerMesas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerMesas.Name = "btnVerMesas";
            this.btnVerMesas.Size = new System.Drawing.Size(356, 100);
            this.btnVerMesas.TabIndex = 5;
            this.btnVerMesas.Text = "Mesas Ocupadas";
            this.btnVerMesas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerMesas.UseVisualStyleBackColor = false;
            this.btnVerMesas.Click += new System.EventHandler(this.btnVerMesas_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.Black;
            this.btnOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenes.FlatAppearance.BorderSize = 2;
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrdenes.Image = global::Pizzas.Properties.Resources.Ordenes_Buscar;
            this.btnOrdenes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrdenes.Location = new System.Drawing.Point(0, 200);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(356, 100);
            this.btnOrdenes.TabIndex = 5;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnVerOrdenes_Click);
            // 
            // btnCorteCaja
            // 
            this.btnCorteCaja.BackColor = System.Drawing.Color.Black;
            this.btnCorteCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCorteCaja.FlatAppearance.BorderSize = 2;
            this.btnCorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorteCaja.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorteCaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCorteCaja.Image = global::Pizzas.Properties.Resources.Venta;
            this.btnCorteCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCorteCaja.Location = new System.Drawing.Point(0, 400);
            this.btnCorteCaja.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCorteCaja.Name = "btnCorteCaja";
            this.btnCorteCaja.Size = new System.Drawing.Size(356, 100);
            this.btnCorteCaja.TabIndex = 5;
            this.btnCorteCaja.Text = "Cortes de Caja";
            this.btnCorteCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorteCaja.UseVisualStyleBackColor = false;
            this.btnCorteCaja.Click += new System.EventHandler(this.btnCorteCaja_Click);
            // 
            // btnCatalogos
            // 
            this.btnCatalogos.BackColor = System.Drawing.Color.Black;
            this.btnCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogos.FlatAppearance.BorderSize = 2;
            this.btnCatalogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogos.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCatalogos.Image = global::Pizzas.Properties.Resources.Ordenes_Buscar;
            this.btnCatalogos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCatalogos.Location = new System.Drawing.Point(0, 300);
            this.btnCatalogos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCatalogos.Name = "btnCatalogos";
            this.btnCatalogos.Size = new System.Drawing.Size(356, 100);
            this.btnCatalogos.TabIndex = 5;
            this.btnCatalogos.Text = "Catalogos";
            this.btnCatalogos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCatalogos.UseVisualStyleBackColor = false;
            this.btnCatalogos.Click += new System.EventHandler(this.btnVerCatalogos_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Pizzas.Properties.Resources.Fondo_Papel_Viejo;
            this.ClientSize = new System.Drawing.Size(356, 637);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCorteCaja);
            this.Controls.Add(this.btnCatalogos);
            this.Controls.Add(this.btnOrdenes);
            this.Controls.Add(this.btnVerMesas);
            this.Controls.Add(this.btnVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzas Di Carlo";            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVerMesas;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnCorteCaja;
        private System.Windows.Forms.Button btnCatalogos;
    }
}