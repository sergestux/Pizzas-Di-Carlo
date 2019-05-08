namespace Pizzas
{
    partial class FrmCatalogo
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
            this.components = new System.ComponentModel.Container();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.catalogoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.mesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzasDataSet = new Pizzas.pizzasDataSet();
            this.mesaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mesaTableAdapter = new Pizzas.pizzasDataSetTableAdapters.mesaTableAdapter();
            this.tableAdapterManager = new Pizzas.pizzasDataSetTableAdapters.TableAdapterManager();
            this.catalogoDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingNavigator)).BeginInit();
            this.catalogoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoDataGridView)).BeginInit();
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
            this.btnCancelar.Location = new System.Drawing.Point(0, 435);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(390, 100);
            this.btnCancelar.TabIndex = 4;
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 10);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // catalogoBindingNavigator
            // 
            this.catalogoBindingNavigator.AddNewItem = null;
            this.catalogoBindingNavigator.BindingSource = this.mesaBindingSource;
            this.catalogoBindingNavigator.CountItem = null;
            this.catalogoBindingNavigator.DeleteItem = null;
            this.catalogoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesaBindingNavigatorSaveItem});
            this.catalogoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.catalogoBindingNavigator.MoveFirstItem = null;
            this.catalogoBindingNavigator.MoveLastItem = null;
            this.catalogoBindingNavigator.MoveNextItem = null;
            this.catalogoBindingNavigator.MovePreviousItem = null;
            this.catalogoBindingNavigator.Name = "catalogoBindingNavigator";
            this.catalogoBindingNavigator.PositionItem = null;
            this.catalogoBindingNavigator.Size = new System.Drawing.Size(390, 55);
            this.catalogoBindingNavigator.TabIndex = 8;
            this.catalogoBindingNavigator.Text = "bindingNavigator1";
            // 
            // mesaBindingSource
            // 
            this.mesaBindingSource.DataMember = "mesa";
            this.mesaBindingSource.DataSource = this.pizzasDataSet;
            // 
            // pizzasDataSet
            // 
            this.pizzasDataSet.DataSetName = "pizzasDataSet";
            this.pizzasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesaBindingNavigatorSaveItem
            // 
            this.mesaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mesaBindingNavigatorSaveItem.Image = global::Pizzas.Properties.Resources.Guardar;
            this.mesaBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mesaBindingNavigatorSaveItem.Name = "mesaBindingNavigatorSaveItem";
            this.mesaBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 52);
            this.mesaBindingNavigatorSaveItem.Text = "Save Data";
            this.mesaBindingNavigatorSaveItem.Click += new System.EventHandler(this.mesaBindingNavigatorSaveItem_Click);
            // 
            // mesaTableAdapter
            // 
            this.mesaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.mesa_ordenTableAdapter = null;
            this.tableAdapterManager.mesaTableAdapter = this.mesaTableAdapter;
            this.tableAdapterManager.orden_detalleTableAdapter = null;
            this.tableAdapterManager.ordenTableAdapter = null;
            this.tableAdapterManager.producto_especialidadTableAdapter = null;
            this.tableAdapterManager.productoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pizzas.pizzasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // catalogoDataGridView
            // 
            this.catalogoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogoDataGridView.Location = new System.Drawing.Point(0, 72);
            this.catalogoDataGridView.Name = "catalogoDataGridView";
            this.catalogoDataGridView.Size = new System.Drawing.Size(378, 150);
            this.catalogoDataGridView.TabIndex = 9;
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(91)))), ((int)(((byte)(67)))));
            this.BackgroundImage = global::Pizzas.Properties.Resources.Fondo_Papel_Viejo;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(390, 535);
            this.Controls.Add(this.catalogoDataGridView);
            this.Controls.Add(this.catalogoBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Nothing You Could Say", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de Mesas";
            this.Load += new System.EventHandler(this.FrmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingNavigator)).EndInit();
            this.catalogoBindingNavigator.ResumeLayout(false);
            this.catalogoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private pizzasDataSet pizzasDataSet;
        private System.Windows.Forms.BindingSource mesaBindingSource;
        private pizzasDataSetTableAdapters.mesaTableAdapter mesaTableAdapter;
        private pizzasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator catalogoBindingNavigator;
        private System.Windows.Forms.ToolStripButton mesaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView catalogoDataGridView;
    }
}