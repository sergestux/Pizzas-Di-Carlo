using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizzas
{
    public partial class FrmProducto : Form
    {
        public int ProductoId = 0;
        public string ProductoDesc = "";

        public int EspecialidadId = 0;
        public string EspecialidadDesc;
        
        public decimal ProductoPrecio = 0;
        private int Categoria;

        public FrmProducto(int categoria=0)
        {
            this.Categoria = categoria;
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ProductoId == 0)
                return;

            if (Categoria == 1 && EspecialidadId == 0)     //Si son las pizzas                            
                return;          
                
            this.Close();
        }        


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ProductoId = 0;
        }


        private void FrmAlgoMas_Load(object sender, EventArgs e)
        {   
            CargarCategoria(this.Categoria);
            if (this.Categoria == 1)       //Si son las pizzas
                CargarEspecialidad();       //Cargo las especialidades de la pizza            
        }

        
        private void CargarCategoria(int categoria)
        {
            pizzasDataSet.productoDataTable Ds = new pizzasDataSet.productoDataTable();
            Ds = productoTableAdapter.GetDataByCategoria(categoria);
            int Cant = Ds.Count;

            for (int Cont = 0; Cont < Cant; Cont++)
            {
                RadioButton btnNew = new RadioButton();
                btnNew.Appearance = Appearance.Button;
                btnNew.Font = new System.Drawing.Font("Nothing You Could Say", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnNew.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnNew.FlatAppearance.BorderSize = 0;
                btnNew.FlatAppearance.CheckedBackColor=Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
                btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
                btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
                btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnNew.UseVisualStyleBackColor = true;
                btnNew.AutoSize = true;

                btnNew.Tag = Convert.ToInt32(Ds.Rows[Cont]["id"]);
                btnNew.Text = Ds.Rows[Cont]["descripcion"].ToString();
                btnNew.Click += btnNew_Click;
                this.PanelProductos.Controls.Add(btnNew);
            }

            if (categoria == 1)
                this.Text = "PIZZAS";
            if (categoria == 2)
                this.Text = "BEBIDAS";
            if (categoria == 3)
                this.Text = "ALGO MAS?...";
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            RadioButton ProductoClicado = (RadioButton)sender;
            ProductoId = Convert.ToInt32(ProductoClicado.Tag);
            ObtenerDetalleProducto(ProductoId);
        }


        private void CargarEspecialidad()
        {            
            pizzasDataSet.producto_especialidadDataTable Ds = new pizzasDataSet.producto_especialidadDataTable();        
            Ds = producto_especialidadTableAdapter.GetData();
            int Cant = Ds.Count;

            for (int Cont = 0; Cont < Cant; Cont++)
            {
                RadioButton btnNew = new RadioButton();
                btnNew.Appearance = Appearance.Button;
                btnNew.Font = new System.Drawing.Font("Nothing You Could Say", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnNew.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btnNew.FlatAppearance.BorderSize = 0;
                btnNew.FlatAppearance.CheckedBackColor = Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
                btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
                btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
                btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnNew.UseVisualStyleBackColor = true;
                btnNew.AutoSize = true;

                btnNew.Tag = Convert.ToInt32(Ds.Rows[Cont]["id"]);
                btnNew.Text = Ds.Rows[Cont]["descripcion"].ToString();
                btnNew.Click += btnNewEspecialidad_Click;
                this.PanelEspecialidad.Controls.Add(btnNew);
            }

            PanelProductos.Width = 240;
            PanelEspecialidad.Width = 200;
            this.Width = 576;
            

        }

        private void btnNewEspecialidad_Click(object sender, EventArgs e)
        {            
            RadioButton ProductoClicado = (RadioButton)sender;         
            EspecialidadId= Convert.ToInt32(ProductoClicado.Tag);
            EspecialidadDesc = ProductoClicado.Text; 
        }

        
        //Obtiene los detalles del producto
        private void ObtenerDetalleProducto(int ProdId)
        {
            pizzasDataSet.productoDataTable Ds = new pizzasDataSet.productoDataTable();
            Ds = productoTableAdapter.GetDataById(ProdId);
            int CantRegistros = Ds.Count;

            if (CantRegistros > 0)
            {
                ProductoId = (int)Ds.Rows[0]["id"];
                ProductoDesc = Ds.Rows[0]["descripcion"].ToString();
                ProductoPrecio = Convert.ToDecimal(Ds.Rows[0]["precio"]);
            }
        }

    }
}
