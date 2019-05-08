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
    public partial class FrmMesasOcupadas : Form
    {
        int OrdenId = 0;

        public FrmMesasOcupadas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    //Cierra éste el formulario     
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            //int Result;

            FrmOrden Frm = new FrmOrden(OrdenId);
            Frm.Show();
            this.Close();            
        }
        

        private void btnNew_Click(object sender, EventArgs e)
        {
            Button MesaClicada = (Button)sender;
            MesaClicada.BackColor = Color.Black;            
            DeseleccionarBotones(MesaClicada);  //Deselecciona los demas botones menos este
            OrdenId = Convert.ToInt32(MesaClicada.Tag);     //Recuperamos el cliente de la orden
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

        
        private void TecladoNumerico(object sender, MouseEventArgs e)
        {
            Utils.TecladoNumerico(sender);

        }

        private void FrmMesasOcupadas_Load(object sender, EventArgs e)
        {
            this.mesa_orden_detalleTableAdapter.Fill(this.pizzasDataSet.mesa_orden_detalle);
            String Archivo = "Mesa.png";

            pizzasDataSet.mesa_orden_detalleDataTable Ds = new pizzasDataSet.mesa_orden_detalleDataTable();
            Ds = mesa_orden_detalleTableAdapter.GetData();
            int CantMesas = Ds.Count;
            String RotuloMesa = "";
            String ClienteRecortado = "";
            decimal Total = 0;

            for (int Cont = 0; Cont < CantMesas; Cont++)
            {
                Button btnNew = new Button();
                btnNew.Tag = Convert.ToInt32(Ds.Rows[Cont]["OrdenId"]);   //ID
                RotuloMesa = Ds.Rows[Cont]["Mesa"].ToString();     //MESA

                ClienteRecortado = Ds.Rows[Cont]["Cliente"].ToString();     //CLIENTE
                if (ClienteRecortado.Length > 13)
                    ClienteRecortado = ClienteRecortado.Substring(0, 11) + "...";
                RotuloMesa = RotuloMesa + "\n" + ClienteRecortado;
                Total = Convert.ToDecimal(Ds.Rows[Cont]["Total"].ToString());                //TOTAL
                RotuloMesa = RotuloMesa + "\n" + string.Format("{0:C2}", Total);     //TOTAL
                btnNew.Text = RotuloMesa;

                btnNew.Height = 150;
                btnNew.Width = 150;
                btnNew.FlatStyle = FlatStyle.Flat;
                btnNew.Image = new Bitmap(Archivo);

                btnNew.Click += btnNew_Click;

                this.PanelMesas.Controls.Add(btnNew);
            }
        }
      
    }
}
