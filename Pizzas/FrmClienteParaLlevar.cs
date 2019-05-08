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
    public partial class FrmClienteParaLLevar : Form
    {
        public FrmClienteParaLLevar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    //Cierra éste el formulario     
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {   
            int ClienteId;
            int OrdenId;
            int Result;
            if (txtNombre.Text.Length == 0)
                return;
            Result=clienteTableAdapter.Insert(txtNombre.Text,"", "Para llevar", 1);
            if (Result == 1)
            {
                ClienteId = (int)clienteTableAdapter.getLastId();
                OrdenId = Utils.GenerarOrden(ClienteId, Utils.UsuarioId, 2);    //Usuario 1, Tipo de venta 3 (a domicilio)
                if (OrdenId > 0)
                {
                    FrmOrden Frm = new FrmOrden(OrdenId);
                    Frm.Show();
                    this.Close();
                }
                else
                    Console.WriteLine("NO SE PUDO GENERAR LA ORDEN");
            }           


        }
       

        private void TecladoAlfaNumerico(object sender, EventArgs e)
        {
            Utils.TecladoAlfaNumerico(sender);
        }      

      
    }
}
