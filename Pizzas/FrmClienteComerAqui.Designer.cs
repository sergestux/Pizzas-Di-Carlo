namespace Pizzas
{
    partial class FrmClienteComerAqui
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pizzasDataSet = new Pizzas.pizzasDataSet();
            this.PanelMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.lblmesa = new System.Windows.Forms.Label();
            this.mesa_orden_detalleTableAdapter = new Pizzas.pizzasDataSetTableAdapters.mesa_orden_detalleTableAdapter();
            this.clienteTableAdapter = new Pizzas.pizzasDataSetTableAdapters.clienteTableAdapter();
            this.mesa_ordenTableAdapter = new Pizzas.pizzasDataSetTableAdapters.mesa_ordenTableAdapter();
            this.mesa_desocupadaTableAdapter = new Pizzas.pizzasDataSetTableAdapters.mesa_desocupadaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(101, 9);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 33);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Click += new System.EventHandler(this.TecladoAlfanumerico);
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
            this.btnCancelar.Location = new System.Drawing.Point(248, 344);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 100);
            this.btnCancelar.TabIndex = 5;
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
            this.btnAceptar.Image = global::Pizzas.Properties.Resources.Aceptar;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(0, 344);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(143, 100);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pizzas.Properties.Resources.Division;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 10);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pizzasDataSet
            // 
            this.pizzasDataSet.DataSetName = "pizzasDataSet";
            this.pizzasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelMesas
            // 
            this.PanelMesas.AutoScroll = true;
            this.PanelMesas.BackColor = System.Drawing.Color.Transparent;
            this.PanelMesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMesas.Location = new System.Drawing.Point(0, 51);
            this.PanelMesas.Name = "PanelMesas";
            this.PanelMesas.Size = new System.Drawing.Size(401, 241);
            this.PanelMesas.TabIndex = 2;
            // 
            // lblmesa
            // 
            this.lblmesa.Location = new System.Drawing.Point(0, 295);
            this.lblmesa.Name = "lblmesa";
            this.lblmesa.Size = new System.Drawing.Size(391, 26);
            this.lblmesa.TabIndex = 3;
            this.lblmesa.Text = "label5";
            this.lblmesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mesa_orden_detalleTableAdapter
            // 
            this.mesa_orden_detalleTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // mesa_ordenTableAdapter
            // 
            this.mesa_ordenTableAdapter.ClearBeforeFill = true;
            // 
            // mesa_desocupadaTableAdapter
            // 
            this.mesa_desocupadaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmClienteComerAqui
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(91)))), ((int)(((byte)(67)))));
            this.BackgroundImage = global::Pizzas.Properties.Resources.Fondo_Papel_Viejo;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(413, 454);
            this.Controls.Add(this.lblmesa);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelMesas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Nothing You Could Say", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteComerAqui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente Para Comer Acá";
            this.Load += new System.EventHandler(this.FrmClienteDomicilio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private pizzasDataSet pizzasDataSet;
        private System.Windows.Forms.FlowLayoutPanel PanelMesas;
        private System.Windows.Forms.Label lblmesa;
        private pizzasDataSetTableAdapters.mesa_orden_detalleTableAdapter mesa_orden_detalleTableAdapter;
        private pizzasDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private pizzasDataSetTableAdapters.mesa_ordenTableAdapter mesa_ordenTableAdapter;
        private pizzasDataSetTableAdapters.mesa_desocupadaTableAdapter mesa_desocupadaTableAdapter;
    }
}