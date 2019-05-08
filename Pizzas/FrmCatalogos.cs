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
    public partial class FrmCatalogos : Form
    {
        public FrmCatalogos()
        {
            InitializeComponent();
        }

                
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            //FrmCatalogo Frm = new FrmCatalogo("mesa");
            //Frm.ShowDialog();
        }
        
        

        private void btnVerCatalogoMesas_Click(object sender, EventArgs e)
        {
            FrmMesasCatalogo Frm = new FrmMesasCatalogo();
            Frm.ShowDialog();
        }
               

        private void btnVerCatalogoUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuariosCatalogo Frm = new FrmUsuariosCatalogo();
            Frm.ShowDialog();
        }

        private void btnVerCatalogoProductos_Click(object sender, EventArgs e)
        {
            FrmProductosCatalogo Frm = new FrmProductosCatalogo();
            Frm.ShowDialog();
        }

        private void btnVerCatalogoClientes_Click(object sender, EventArgs e)
        {
            FrmClientesCatalogo Frm = new FrmClientesCatalogo();
            Frm.ShowDialog();
        }

        
        
    }
}
