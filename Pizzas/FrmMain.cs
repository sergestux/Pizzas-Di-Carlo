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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FrmVentaTipo Frm = new FrmVentaTipo();
            Frm.Show();

        }

        private void btnVerMesas_Click(object sender, EventArgs e)
        {
            FrmMesasOcupadas Frm = new FrmMesasOcupadas();
            Frm.Show();
        }

        private void btnVerOrdenes_Click(object sender, EventArgs e)
        {
            FrmOrdenes Frm = new FrmOrdenes();
            Frm.ShowDialog();
        }


        private void btnVerCatalogos_Click(object sender, EventArgs e)
        {
            FrmCatalogos Frm = new FrmCatalogos();
            Frm.ShowDialog();
        }    

       
        

        private void btnCorteCaja_Click(object sender, EventArgs e)
        {
            FrmCortes Frm = new FrmCortes();
            Frm.ShowDialog();
        }

       

        
    }
}
