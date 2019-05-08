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
    public partial class FrmClientesCatalogo : Form
    {
        public FrmClientesCatalogo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    //Cierro este formulario
        }      

       //Al dar click en el boton de guardar
        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzasDataSet);
        }

        //Al iniciar el formulario
        private void FrmClientesCatalogo_Load(object sender, EventArgs e)
        {   
            //Solamente los clientes a domicilio
            this.clienteTableAdapter.FillClientesDomicilio(this.pizzasDataSet.cliente);
        }
    }
}
