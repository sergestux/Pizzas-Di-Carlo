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
    public partial class FrmMesasCatalogo : Form
    {
        public FrmMesasCatalogo()
        {
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

        private void FrmMesasCatalogo_Load(object sender, EventArgs e)
        {            
            this.mesaTableAdapter.Fill(this.pizzasDataSet.mesa);
        }
    }
}
