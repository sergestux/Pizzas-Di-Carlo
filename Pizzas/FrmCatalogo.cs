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
    public partial class FrmCatalogo : Form
    {
        public string Catalogo;
        private BindingSource CatalogoBindingSource;

        public FrmCatalogo(string catalogo)
        {
            Catalogo = catalogo;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    //Cierra el formulario y por lo tanto la aplicación            

        }
       

        private void mesaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.mesaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzasDataSet);
            
        }

        
        private void FrmCatalogo_Load(object sender, EventArgs e)
        {
            //this.mesaTableAdapter.Fill(this.pizzasDataSet.mesa);
            

            if (Catalogo.Equals("mesa"))
            {
                //this.mesaTableAdapter.Fill(this.pizzasDataSet.mesa);
                pizzasDataSetTableAdapters.mesaTableAdapter Adaptador = new pizzasDataSetTableAdapters.mesaTableAdapter();
                Adaptador.Fill(this.pizzasDataSet.mesa);
                CatalogoBindingSource.DataSource = Adaptador;
            }
            
            if (Catalogo.Equals("cliente"))
            {   
                //pizzasDataSetTableAdapters.mesaTableAdapter Adaptador = new pizzasDataSetTableAdapters.mesaTableAdapter();
                pizzasDataSetTableAdapters.clienteTableAdapter Adaptador = new pizzasDataSetTableAdapters.clienteTableAdapter();
                Adaptador.Fill(this.pizzasDataSet.cliente);
            }

            if (Catalogo.Equals("producto"))
            {
                //pizzasDataSetTableAdapters.mesaTableAdapter Adaptador = new pizzasDataSetTableAdapters.mesaTableAdapter();
                pizzasDataSetTableAdapters.productoTableAdapter Adaptador = new pizzasDataSetTableAdapters.productoTableAdapter();
                Adaptador.Fill(this.pizzasDataSet.producto);
            }
            
            //CatalogoBindingSource.DataSource = new pizzasDataSet();
            CatalogoBindingSource.DataMember = Catalogo;            
            catalogoBindingNavigator.BindingSource = CatalogoBindingSource;            
            catalogoDataGridView.DataSource = CatalogoBindingSource;
        }
    }
}
