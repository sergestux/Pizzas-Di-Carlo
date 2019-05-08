using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;               //Hay que agregar la referencia al proyecto
using MySql.Data.MySqlClient;

namespace Pizzas
{
    public partial class FrmOrdenes : Form
    {
        public int Estado = 0;      //El estado de las ordenes que se van a mostrarpor default

        //Le paso el id de la orden
        public FrmOrdenes(int estado=0)
        {
            this.Estado = estado;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    //Cierra éste el formulario        
        }

        

        private void VerDetalleOrden(object sender, DataGridViewCellEventArgs e)
        {
            int OrdenId = 0;            
            OrdenId = Convert.ToInt32(dgOrdenes.CurrentRow.Cells[0].Value);
            FrmOrden Frm = new FrmOrden(OrdenId);
            Frm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.orden_detalladaTableAdapter.FillBy(pizzasDataSet.orden_detallada, dtFechaInicial.Value.Date, dtFechaFinal.Value.Date.AddHours(23.9999)); 
            orden_detalladaBindingSource.DataSource = this.pizzasDataSet.orden_detallada;
            RecalcularTotales();
            cmbStatus.SelectedIndex = 0;
        }
        

        private void FrmOrdenes_Load(object sender, EventArgs e)
        {           
            this.orden_detalladaTableAdapter.FillBy(pizzasDataSet.orden_detallada, dtFechaInicial.Value.Date, dtFechaFinal.Value.Date.AddHours(23.9999));
            orden_detalladaBindingSource.DataSource = this.pizzasDataSet.orden_detallada;
            dgOrdenes.DataSource = orden_detalladaBindingSource;
            RecalcularTotales();
            cmbStatus.SelectedIndex = this.Estado;    //Por Default muestro solo las ordenes Abiertas
            this.BringToFront();    //Traigo al frente el formulario
            
        }     


        private void RecalcularTotales()
        {
            int Registros = dgOrdenes.Rows.Count;
            decimal Total = 0;

            for (int Cont = 0; Cont < Registros; Cont++)
            {
                Total += Convert.ToDecimal(dgOrdenes.Rows[Cont].Cells[8].Value);
            }

            lblTotal.Text = "TOTAL: " + string.Format("{0:C2}", Total);
            lblTotalLetras.Text=Utils.NumLetras(Convert.ToDouble(Total));            
            
        }

        private void FiltrarStatus(object sender, EventArgs e)
        {
            Filtrar(cmbStatus.SelectedIndex);
        }

        //Filtra el resultado obtenido por Status (Por ahora)
        private void Filtrar(int Status)
        {
            if (Status == 0)
                orden_detalladaBindingSource.RemoveFilter();
            else
            {
                String Filtro = "status=" + Status;
                orden_detalladaBindingSource.Filter = Filtro;
            }
            RecalcularTotales();
        }
      
    }
}
