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
    public partial class FrmVentaTipo : Form
    {
        public FrmVentaTipo()
        {
            InitializeComponent();
        }       
       

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            FrmClienteDomicilio Frm = new FrmClienteDomicilio();
            Frm.Show();
            this.Close();
        }

        private void btnComerAca_Click(object sender, EventArgs e)
        {
            FrmClienteComerAqui Frm = new FrmClienteComerAqui();
            Frm.Show();
            this.Close();
   
        }

        private void btnLLevar_Click(object sender, EventArgs e)
        {
            FrmClienteParaLLevar Frm = new FrmClienteParaLLevar();
            Frm.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    //Cierra el formulario y por lo tanto la aplicación 
        }
       
    }
}
