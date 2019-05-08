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
    public partial class FrmUsuariosCatalogo : Form
    {
        public FrmUsuariosCatalogo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    //Cierra el formulario y por lo tanto la aplicación 
        }
                

        private void mesaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzasDataSet);
        }

        private void FrmUsuariosCatalogo_Load(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.Fill(this.pizzasDataSet.usuario);
        }
    }
}
