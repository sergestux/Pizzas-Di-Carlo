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
    public partial class FrmClienteComerAqui : Form
    {
        int MesaId = 0;
        int ClienteId = 0;

        public FrmClienteComerAqui()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    //Cierra éste el formulario     
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            int OrdenId = 0;
            int Result;

            if (txtNombre.Text.Length == 0)
                return;
            //INSERTAMOS EL CLIENTE
            Result = clienteTableAdapter.Insert(txtNombre.Text, "", "Para comer aqui", 1);

            if (Result == 1)
            {
                ClienteId = (int)clienteTableAdapter.getLastId();
                
                //GENERAMOS LA ORDEN
                //+++++++++++++++++++++FALTA CAPTURAR EL USUARIO+++++++++++++++//
                OrdenId=Utils.GenerarOrden(ClienteId, Utils.UsuarioId, 1);    //Usuario 1, Tipo de venta 1 (para aqui)
                if (OrdenId > 0)
                {   //Ligo la orden con la mesa correspondiente
                    Result = mesa_ordenTableAdapter.ActualizaMesaOrden(OrdenId, MesaId);
                    
                    if (Result == 1)
                    {
                        FrmOrden Frm = new FrmOrden(OrdenId);
                        Frm.Show();
                        this.Close();
                    }
                }
            }            
        }
       

        private void FrmClienteDomicilio_Load(object sender, EventArgs e)
        {
            //this.mesa_orden_detalleTableAdapter.Fill(this.pizzasDataSet.mesa_orden_detalle);
            String Archivo="Mesa.png";
            lblmesa.Text = "";

            pizzasDataSet.mesa_desocupadaDataTable Ds = new pizzasDataSet.mesa_desocupadaDataTable();
            Ds = mesa_desocupadaTableAdapter.GetData();
            int CantMesas = Ds.Count;

            if (CantMesas == 0)
            {
                MessageBox.Show("NO HAY MESAS DISPONIBLES", "LO SIENTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();    
            }
            
            for (int Cont = 0; Cont < CantMesas; Cont++)
            {
                Button btnNew = new Button();                
                btnNew.Tag = Ds.Rows[Cont]["mesa_id"].ToString();
                btnNew.Text =Ds.Rows[Cont]["mesa_descripcion"].ToString();

                btnNew.Height = 93;
                btnNew.Width = 68;
                btnNew.FlatStyle = FlatStyle.Flat;
                btnNew.Image = new Bitmap(Archivo);               
                btnNew.Click += btnNew_Click;
                
                this.PanelMesas.Controls.Add(btnNew);
            }
        }

        

        private void btnNew_Click(object sender, EventArgs e)
        {
            Button MesaClicada = (Button)sender;
            MesaClicada.BackColor = Color.Black;
            lblmesa.Text = MesaClicada.Text;
            DeseleccionarBotones(MesaClicada);  //Deselecciona los demas botones menos este
            MesaId = Convert.ToInt32(MesaClicada.Tag); //Recupera la mesa seleccionada
        }


        //Deselecciona todos los botones, menos el que se le pasa
        private void DeseleccionarBotones(Button Boton)
        {
            foreach (var control in PanelMesas.Controls)
            {
                Button BotonActual= control as Button;
                if (BotonActual != Boton)     //Si no es el boton que se paso como argumento
                    BotonActual.BackColor = Color.Transparent;                
            }

        }
       

        private void TecladoAlfanumerico(object sender, EventArgs e)
        {
            Utils.TecladoAlfaNumerico(sender);
        }      

      
    }
}
