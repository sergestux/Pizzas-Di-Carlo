namespace Pizzas
{
    partial class FrmCortes
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
            this.btnCorteParcial = new System.Windows.Forms.Button();
            this.btnCorteFinal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pizzasDataSet = new Pizzas.pizzasDataSet();
            this.corte_cajaTableAdapter = new Pizzas.pizzasDataSetTableAdapters.corte_cajaTableAdapter();
            this.corte_caja_fechaTableAdapter = new Pizzas.pizzasDataSetTableAdapters.corte_caja_fechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Pizzas.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(0, 382);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(389, 100);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCorteParcial
            // 
            this.btnCorteParcial.BackColor = System.Drawing.Color.Black;
            this.btnCorteParcial.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCorteParcial.FlatAppearance.BorderSize = 2;
            this.btnCorteParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorteParcial.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorteParcial.Image = global::Pizzas.Properties.Resources.Venta_a_Domicilio1;
            this.btnCorteParcial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCorteParcial.Location = new System.Drawing.Point(118, 5);
            this.btnCorteParcial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCorteParcial.Name = "btnCorteParcial";
            this.btnCorteParcial.Size = new System.Drawing.Size(120, 100);
            this.btnCorteParcial.TabIndex = 0;
            this.btnCorteParcial.Text = "CorteParcial";
            this.btnCorteParcial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorteParcial.UseVisualStyleBackColor = false;
            this.btnCorteParcial.Click += new System.EventHandler(this.btnCorteParcial_Click);
            // 
            // btnCorteFinal
            // 
            this.btnCorteFinal.BackColor = System.Drawing.Color.Black;
            this.btnCorteFinal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCorteFinal.FlatAppearance.BorderSize = 2;
            this.btnCorteFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorteFinal.Font = new System.Drawing.Font("Nothing You Could Say", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorteFinal.Image = global::Pizzas.Properties.Resources.Venta___Para_comer_aqui;
            this.btnCorteFinal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCorteFinal.Location = new System.Drawing.Point(118, 103);
            this.btnCorteFinal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCorteFinal.Name = "btnCorteFinal";
            this.btnCorteFinal.Size = new System.Drawing.Size(120, 100);
            this.btnCorteFinal.TabIndex = 1;
            this.btnCorteFinal.Text = "Corte Final";
            this.btnCorteFinal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorteFinal.UseVisualStyleBackColor = false;
            this.btnCorteFinal.Click += new System.EventHandler(this.btnCorteFinal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pizzas.Properties.Resources.Division;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 10);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pizzasDataSet
            // 
            this.pizzasDataSet.DataSetName = "pizzasDataSet";
            this.pizzasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // corte_cajaTableAdapter
            // 
            this.corte_cajaTableAdapter.ClearBeforeFill = true;
            // 
            // corte_caja_fechaTableAdapter
            // 
            this.corte_caja_fechaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Pizzas.Properties.Resources.Fondo_Papel_Viejo;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(389, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCorteFinal);
            this.Controls.Add(this.btnCorteParcial);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Nothing You Could Say", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCortes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cortes de Caja";
            this.Load += new System.EventHandler(this.FrmCortes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCorteParcial;
        private System.Windows.Forms.Button btnCorteFinal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private pizzasDataSet pizzasDataSet;
        private pizzasDataSetTableAdapters.corte_cajaTableAdapter corte_cajaTableAdapter;
        private pizzasDataSetTableAdapters.corte_caja_fechaTableAdapter corte_caja_fechaTableAdapter;
    }
}