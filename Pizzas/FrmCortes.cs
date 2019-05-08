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
    public partial class FrmCortes : Form
    {
        public FrmCortes()
        {
            InitializeComponent();
        }


        private void FrmCortes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzasDataSet.corte_caja_fecha' table. You can move, or remove it, as needed.
            this.corte_caja_fechaTableAdapter.Fill(this.pizzasDataSet.corte_caja_fecha);
            this.corte_cajaTableAdapter.Fill(this.pizzasDataSet.corte_caja);            
        }

        
        private void btnCorteParcial_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta;

            Respuesta = MessageBox.Show("¿Desea Imprimir el corte de caja del día?", "CORTE DE CAJA", MessageBoxButtons.YesNo);
            if (Respuesta == System.Windows.Forms.DialogResult.Yes)  //Si responde que si
            {                
                pizzasDataSet.corte_cajaDataTable Ds = new pizzasDataSet.corte_cajaDataTable();
                Ds = corte_cajaTableAdapter.GetData();      //Hago el corte de caja del dia, (la fecha actual la tomo del servidor MySQL)    
                ImprimirCorte(Ds);
            }
        }

       
        private void btnCorteFinal_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta;

            Respuesta = MessageBox.Show("¿Desea Imprimir el corte de caja del día?", "CORTE DE CAJA", MessageBoxButtons.YesNo);
            if (Respuesta == System.Windows.Forms.DialogResult.Yes)  //Si responde que si
            {
                pizzasDataSet.corte_caja_fechaDataTable Ds = new pizzasDataSet.corte_caja_fechaDataTable();

                DateTime FechaActual = DateTime.Now;
                DateTime FechaIni=FechaActual;  

                if (FechaActual.Hour < 6)      //Si es de madrugada de las 12 a a las 5:59 de la mañana
                    FechaIni = FechaActual.AddDays(-1);     //Resto un dia a la fecha Inicial para obtener el dia de ayer
                
                
                String FechaInicial = FechaIni.ToShortDateString() + " 06:00:00";   //Desde las 6 de la mañana
                
                Ds = corte_caja_fechaTableAdapter.GetCorteByFechas(Convert.ToDateTime(FechaInicial), FechaActual);                
                ImprimirCorteFechas(Ds);
            }
        }


        //Imprime el corte de caja entre el rango de fechas que se le pase
        private void ImprimirCorteFechas(pizzasDataSet.corte_caja_fechaDataTable Ds)
        {
            int CantRegistros = Ds.Count;
            string FechaActual;

            if (CantRegistros > 0)
            {
                int Cont = 0;

                //COMPRUEBO QUE NO HAYA ORDENES ABIERTAS                    
                for (Cont = 0; Cont < CantRegistros; Cont++)
                {
                    if (Convert.ToInt32(Ds.Rows[Cont]["status"]) == 1)        //Si la orden sigue abierta
                    {
                        MessageBox.Show("Aún hay ordenes abiertas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FrmOrdenes Frm = new FrmOrdenes(1); //Indico que se mostraran las ordenes Abierta
                        Frm.ShowDialog();
                        return; //Salgo de la funcion actual
                    }
                }

                //Saco la fecha de la primer orden
                FechaActual = Convert.ToDateTime(Ds.Rows[0]["fecha_hora"]).ToShortDateString(); ;

                Ticket ticket = new Ticket();
                int id;
                string tipoventa;
                decimal monto;

                //IMPRIMO LOSENCABEZADOS
                ticket.AddHeaderLine("CORTE DE CAJA DEL DIA: " + FechaActual);
                ticket.AddSubHeaderLine("Impresion: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString()); //Por ahora saca la fecha del cliente, deberia sacarla del servidor

                //IMPRIMO LAS COBRADAS
                decimal TotalCobradas = 0;
                int CantCobradas = 0;

                ticket.AddSubHeaderLine("ORDENES COBRADAS");


                ticket.SetEncabezadoColumna("ORDEN     TIPO VENTA     IMPORTE");
                //ticket.SetEncabezadoColumna("CANT  DESCRIPCION           IMPORTE");

                for (Cont = 0; Cont < CantRegistros; Cont++)
                {
                    if (Convert.ToInt32(Ds.Rows[Cont]["status"]) == 2)        //Si la orden esta cobrada
                    {
                        id = Convert.ToInt32(Ds.Rows[Cont]["id"]);
                        tipoventa = Ds.Rows[Cont]["Tipo Venta"].ToString();
                        monto = Convert.ToDecimal(Ds.Rows[Cont]["total"]);
                        ticket.AddItem(id.ToString(), tipoventa, String.Format("{0:N2}", monto));
                        TotalCobradas += monto;         //Sumo el total de la venta
                        CantCobradas++;                 //Aumento la cantidad de ordenes cobradas
                    }
                }

                //IMPRIMO EL TOTAL DE LAS COBRADAS
                //TotalCobradas
                ticket.AddTotal("CANT. DE ORDENES COBRADAS", String.Format("{0:N0}", CantCobradas));
                ticket.AddTotal("TOTAL: ", String.Format("{0:C2}", TotalCobradas));
                //Imprimo el reporte
                ticket.PrintTicket();
            }
            else
            {
                MessageBox.Show("No hay ninguna orden el dia de hoy", "Nada Aun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        //Imprime el corte del dia actual
        private void ImprimirCorte(pizzasDataSet.corte_cajaDataTable Ds)
        {           

                int CantRegistros = Ds.Count;
                string FechaActual;

                if (CantRegistros > 0)
                {
                    int Cont = 0;

                    //COMPRUEBO QUE NO HAYA ORDENES ABIERTAS                    
                    for (Cont = 0; Cont < CantRegistros; Cont++)
                    {
                        if (Convert.ToInt32(Ds.Rows[Cont]["status"]) == 1)        //Si la orden sigue abierta
                        {
                            MessageBox.Show("Aún hay ordenes abiertas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            FrmOrdenes Frm = new FrmOrdenes(1); //Indico que se mostraran las ordenes Abierta
                            Frm.ShowDialog();
                            return; //Salgo de la funcion actual
                        }
                    }

                    //Saco la fecha de la primer orden
                    FechaActual = Convert.ToDateTime(Ds.Rows[0]["fecha_hora"]).ToShortDateString(); ;

                    Ticket ticket = new Ticket();
                    int id;
                    string tipoventa;
                    decimal monto;

                    //IMPRIMO LOSENCABEZADOS
                    ticket.AddHeaderLine("CORTE DE CAJA DEL DIA: " + FechaActual);
                    ticket.AddSubHeaderLine("Impresion: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString()); //Por ahora saca la fecha del cliente, deberia sacarla del servidor

                    //IMPRIMO LAS COBRADAS
                    decimal TotalCobradas = 0;
                    int CantCobradas = 0;

                    ticket.AddSubHeaderLine("ORDENES COBRADAS");


                    ticket.SetEncabezadoColumna("ORDEN     TIPO VENTA     IMPORTE");
                    //ticket.SetEncabezadoColumna("CANT  DESCRIPCION           IMPORTE");

                    for (Cont = 0; Cont < CantRegistros; Cont++)
                    {
                        if (Convert.ToInt32(Ds.Rows[Cont]["status"]) == 2)        //Si la orden esta cobrada
                        {
                            id = Convert.ToInt32(Ds.Rows[Cont]["id"]);
                            tipoventa = Ds.Rows[Cont]["Tipo Venta"].ToString();
                            monto = Convert.ToDecimal(Ds.Rows[Cont]["total"]);
                            ticket.AddItem(id.ToString(), tipoventa, String.Format("{0:N2}", monto));
                            TotalCobradas += monto;         //Sumo el total de la venta
                            CantCobradas++;                 //Aumento la cantidad de ordenes cobradas
                        }
                    }

                    //IMPRIMO EL TOTAL DE LAS COBRADAS
                    //TotalCobradas
                    ticket.AddTotal("CANT. DE ORDENES COBRADAS", String.Format("{0:N0}", CantCobradas));
                    ticket.AddTotal("TOTAL: ", String.Format("{0:C2}", TotalCobradas));
                    //Imprimo el reporte
                    ticket.PrintTicket();
                }
                else
                {
                    MessageBox.Show("No hay ninguna orden el dia de hoy", "Nada Aun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    //Cierra el formulario y por lo tanto la aplicación 
        }

       

    }
}
