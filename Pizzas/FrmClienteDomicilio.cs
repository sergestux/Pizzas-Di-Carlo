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
    public partial class FrmClienteDomicilio : Form
    {
        int ClienteId = 0;

        public FrmClienteDomicilio()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    //Cierra éste el formulario     
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {               
            int OrdenId;
            int Result;
            if (ValidarDatos())
            {
                if (ClienteId == 0)    //Si es un cliente nuevo Lo inserto
                {
                    Result = clienteTableAdapter.Insert(txtNombre.Text, txtTelefono.Text, txtDomicilio.Text, 1);
                    if (Result == 1)                    
                        ClienteId = (int)clienteTableAdapter.getLastId();
                }
                else   //Lo actualizo
                {                    
                    Result = clienteTableAdapter.UpdateById(txtNombre.Text, txtTelefono.Text, txtDomicilio.Text, ClienteId);
                }
                    

                
                OrdenId = Utils.GenerarOrden(ClienteId, Utils.UsuarioId, 3);    //Usuario 1, Tipo de venta 3 (a domicilio)
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

        private bool ValidarDatos()
        {
            bool Retorno = true;
            if (txtTelefono.TextLength == 0)
                Retorno = false;
            if (txtNombre.TextLength == 0)
                Retorno = false;
            if (txtDomicilio.TextLength == 0)
                Retorno = false;

            return Retorno;
        }

        
        private void TecladoNumerico(object sender, MouseEventArgs e)
        {
            Utils.TecladoNumerico(sender);
            if(txtTelefono.TextLength>0)
                CargarCliente(txtTelefono.Text);
        }

        private void TecladoAlfaNumerico(object sender, EventArgs e)
        {
            Utils.TecladoAlfaNumerico(sender);
        }

        //Carga el cliente segun el telefono que se le pase
        private void CargarCliente(string Telefono)
        {
            pizzasDataSet.clienteDataTable Ds = new pizzasDataSet.clienteDataTable();
            Ds = clienteTableAdapter.GetDataByTelefono(Telefono);
            int Cant = Ds.Count;
            if (Cant > 0)
            {
                ClienteId = Convert.ToInt32(Ds.Rows[0]["id"]);
                txtNombre.Text = Ds.Rows[0]["nombre"].ToString();
                txtDomicilio.Text = Ds.Rows[0]["domicilio"].ToString();
            }
        }

              
      
    }
}
