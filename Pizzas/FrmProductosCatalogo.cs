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
    public partial class FrmProductosCatalogo : Form
    {
        
        public FrmProductosCatalogo()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzasDataSet);
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {   
            this.productoTableAdapter.Fill(this.pizzasDataSet.producto);            
        }
    }
}
