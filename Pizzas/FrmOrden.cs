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
    public partial class FrmOrden : Form
    {
        public int ClienteId;
        public int ClienteTipo;
        public int OrdenId;
        public int OrdenStatus;
        


        public int ProductoId = 0;
        public string ProductoDesc = "";
        public int EspecialidadId = 0;
        public decimal ProductoPrecio = 0;

        public decimal SubTotal = 0;        //Para guardar el subtotal de la orden
        public decimal Descuento = 0;       
        public decimal TotalOrden = 0;
        

        //Le paso el id de la orden
        public FrmOrden(int ordenId=0)
        {   
            this.OrdenId = ordenId;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta;

            Respuesta=MessageBox.Show("¿Seguro desea Cancelar esta Orden?", "Cancelar Orden", MessageBoxButtons.YesNo);
            if (Respuesta== System.Windows.Forms.DialogResult.Yes)  //Si responde que si
            {
                //Actualizo el status de la orden actual a cancelada
                ordenTableAdapter.UpdateEstadoById(3, OrdenId);     //Actualizo la orden a cancelada
                Close();    //Cierra éste el formulario        
            }

        }


        //Cobrar la orden
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            int Result = 0;

            if (TotalOrden < 1)
            {
                MessageBox.Show("Aun no hay ningun producto en la orden", "No se puede cobrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            //Actualizo el estado de orden a cerrada                                                                     
            Result = ordenTableAdapter.UpdateEstadoById(2, OrdenId);  //Al actualizarse se ejecuta el triger que pone a 0 la mesa correspondiente cuando es una orden a domicilio           
            if (Result == 1)
            {
                string Pago = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el monto con el que se pagara","Monto del pago");
                if(Pago.Length>0)
                    ImprimirTicket(OrdenId, Convert.ToDecimal(Pago));
                else
                    ImprimirTicket(OrdenId);
                this.Close();    //Cierro este formulario
            }
            else
                Console.WriteLine("No se pudo cambiar el estado de la orden");       //Indico que si hubo errores                
        }
        


        //Guarda subtotal, descuento y total a la orden
        private void GuardarTotales(int ordenId)
        {            
            int Result = ordenTableAdapter.ActualizaTotales(Convert.ToDecimal(txtSubtotal.Tag), Convert.ToDecimal(txtTotal.Tag), Convert.ToDecimal(txtDescuento.Text), ordenId);
            if (Result == 1)
                Console.WriteLine("TOTALES actualizados correctamente");
            else
                Console.WriteLine("ERROR al actualizzar los totales de la orden"); ;       //Indico que si hubo errores
        }


        
        /***************************
         * CADA VEZ QUE SE MANDA A LLAMAR DESDE GUARDAR, VUELVE A INSERTAR
         * que es mas conveniente al agregar o eliminar un nuevo registro al grid, guardarlo
         ***************************/

        //Agrega el detalle del grid a la orden (OrdenId)
        /*
        private bool AgregarDetalleOrden()
        {            
            int producto_id, especialidad_id, cantidad;
            string descripcion;
            decimal importe_unitario, total;
            int Registros = dgOrdenDetalle.Rows.Count;
            int Result;
            bool Errores=false;
            //Recorro el GRID
            for (int Cont = 0; Cont < Registros; Cont++)
            {   //obten los datos renglon por renglon
                producto_id = (int)dgOrdenDetalle.Rows[Cont].Cells["producto_id"].Value;
                especialidad_id = (int)dgOrdenDetalle.Rows[Cont].Cells["especialidad_id"].Value;
                cantidad = Convert.ToInt32(dgOrdenDetalle.Rows[Cont].Cells["cantidad"].Value);
                descripcion = dgOrdenDetalle.Rows[Cont].Cells["Descripcion"].Value.ToString();
                importe_unitario = (decimal)dgOrdenDetalle.Rows[Cont].Cells["ImporteU"].Value;
                total = (decimal)dgOrdenDetalle.Rows[Cont].Cells["Total"].Value;

                Result = 0;                
                Result = orden_detalleTableAdapter.Insert(OrdenId, producto_id, especialidad_id, cantidad, descripcion, importe_unitario, total);

                if (Result == 1)
                    Console.WriteLine(descripcion + " AGREGADO correctamente a la Orden: " + OrdenId);
                else
                    Errores = true;       //Indico que si hubo errores
            }
            return Errores;
        }
         */
       
        //LLama al teclado numerico cuando se de click en la caja de texto correspondiente
        private void TecladoNumerico(object sender, MouseEventArgs e)
        {            
            Utils.TecladoNumerico(sender);
            if (txtCantidad.TextLength > 0)
            {
                BtnAgregarProducto.Enabled = true;
                txtCantidad.Tag = txtCantidad.Text;
           }
        }


        private void BtnPizzas_Click(object sender, EventArgs e)
        {
            ElegirProducto(1);
            /*
            FrmPizzaDetalle Frm = new FrmPizzaDetalle();
            Frm.ShowDialog();
            if (Frm.ProductoId > 0)
            {
                ProductoId = (int)Frm.ProductoId;
                ProductoDesc = Frm.ProductoDesc;
                ProductoDesc += " " + Frm.EspecialidadDesc;
                EspecialidadId = (int)Frm.EspecialidadId;
                ProductoPrecio = Convert.ToDecimal(Frm.ProductoPrecio);
                MostrarProducto();
                HabilitarCantidad(true);
            }
            else
            {
                ProductoDesc = "";
                HabilitarCantidad(false);
            }*/

        }
        
        
        private void BtnBebidas_Click(object sender, EventArgs e)
        {
            ElegirProducto(2);
        }

        private void btnAlgoMas_Click(object sender, EventArgs e)
        {
            ElegirProducto(3);
        }


        //Muestra el formulario para elegir un producto de la categoria que se le pase
        private void ElegirProducto(int categoria=0)
        {
            FrmProducto Frm = new FrmProducto(categoria);
            Frm.ShowDialog();
            if (Frm.ProductoId > 0)
            {
                ProductoId = (int)Frm.ProductoId;
                ProductoDesc = Frm.ProductoDesc.ToString();
                
                ProductoDesc += " " + Frm.EspecialidadDesc;
                EspecialidadId = (int)Frm.EspecialidadId;                

                ProductoPrecio = Convert.ToDecimal(Frm.ProductoPrecio);
                MostrarProducto();
                HabilitarCantidad(true);
            }
            else
            {
                ProductoDesc = "";
                HabilitarCantidad(false);
            }

        }

        //Muestra en la etiqueta el producto, 
        //solo puede llegar aquí cuando se ha elegido previamente un producto
        //Es decir las variables ProductoDesc y ProductoPrecio ya tienen el valor correcto
        private void MostrarProducto()
        {
            lblProducto.Text = ProductoDesc;
            lblProducto.Text += "\t a \t";
            lblProducto.Text += String.Format("{0:C2}", ProductoPrecio) + "\t C/U";
        }



        //Habilita la caja de texto cantidad
        private void HabilitarCantidad(Boolean Opcion)
        {
            if (Opcion)
            {
                txtCantidad.Enabled = true;
                BtnAgregarProducto.Enabled = true;
                txtCantidad.Text = "1";
            }
            else
            {
                txtCantidad.Text = "";
                txtCantidad.Enabled = false;
                BtnAgregarProducto.Enabled = false;
            }
        }
       

        private void FrmOrden_Load(object sender, EventArgs e)
        {   
            this.BringToFront();    //Traigo al frente el formulario
            CargarOrden(OrdenId);               
            HabilitarCantidad(false);
        }


        //Carga la orden que se le pase en el actual formulario
        private void CargarOrden(int ordenId)
        { 
            pizzasDataSet.orden_detalladaDataTable Ds = new pizzasDataSet.orden_detalladaDataTable();
            
            Ds = orden_detalladaTableAdapter.GetDataByd(ordenId);
            int CantRegistros = Ds.Count;
            if (CantRegistros > 0)
            {                
                btnOrdenNumero.Text="Orden: " + Ds.Rows[0]["id"].ToString();
                OrdenStatus = Convert.ToInt32(Ds.Rows[0]["status"]);
                btnOrdenStatus.Text = Ds.Rows[0]["Orden Status"].ToString();
                
                //SI la orden esta cerrada inabilito algunos controles
                if (OrdenStatus == 2 || OrdenStatus == 3)
                    InabilitarControles();

                btnOrdenFecha.Text = Ds.Rows[0]["fecha_hora"].ToString();                
                btnOrdenUsuario.Text = Ds.Rows[0]["Usuario"].ToString();

                groupCliente.Text = "CLIENTE - " + Ds.Rows[0]["Tipo Venta"].ToString();
                ClienteId =Convert.ToInt32(Ds.Rows[0]["cliente_id"]);       //Recupero el cliente que corresponde a la orden
                ClienteTipo =Convert.ToInt32(Ds.Rows[0]["tipo_venta"]);     //Recupero el tipo de Venta
                CargarCliente(ClienteId);   //Cargamos los datos del cliente
                if (ClienteTipo == 1)         //Si es una venta para aqui
                {                    
                    lblDomicilio.Text="Mesa:";
                    txtDomicilio.Text = Ds.Rows[0]["Mesa"].ToString();  //Cargamos la mesa en el campo de domicilio
                    txtDomicilio.Width=250;
                    txtDomicilio.Height=25;                    
                }

                //Cargamos los TOTALES
                txtDescuento.Tag=Ds.Rows[0]["Descuento"].ToString();
                txtDescuento.Text=Ds.Rows[0]["Descuento"].ToString();
                txtSubtotal.Tag = Ds.Rows[0]["subtotal"].ToString();
                txtSubtotal.Text = Ds.Rows[0]["subtotal"].ToString();

                //Cargamos el detalle de la venta
                CargarDetalleOrden(ordenId);
            }
            else
                Console.WriteLine ("Orden Numero:" + ordenId.ToString() + " No encontrada");
        }

        private void InabilitarControles()
        {
            BtnPizzas.Enabled = false;
            BtnBebidas.Enabled = false;
            BtnAlgoMas.Enabled = false;
            txtDescuento.Enabled = false;
            btnCobrar.Enabled = false;
            //dgOrdenDetalle.Enabled = false;
            if(OrdenStatus==3 )  //Si la orden ya fue cancelada
                btnCancelar.Enabled=false;      //Ya no se puede volver a cancelar
            if (OrdenStatus > 1)  //Si el estado de la orden es diferente de ABIERTA
                btnReimprimir.Enabled = true;
            if (OrdenStatus == 3)  //Si la orden ya fue cancelada
            dgOrdenDetalle.ReadOnly = true;     //Ya no dejo que elimine ningun renglon
            
        }

        //Carga el detalle de la orden en el grid
        private void CargarDetalleOrden(int ordenId)
        {
            
            pizzasDataSet.orden_detalleDataTable Ds= new pizzasDataSet.orden_detalleDataTable();                        
            Ds=orden_detalleTableAdapter.GetDataById(ordenId);            
            
            //Recorremos los detalles de la orden
            int Registros = Ds.Count;
            if (Registros > 0)
            {
                int id, producto_id, especialidad_id, cantidad;
                string descripcion;
                decimal importe_unitario, total;
                Int32 Status;
                int Cont=0;
                for (Cont = 0; Cont < Registros; Cont++)
                {
                    id = Convert.ToInt32(Ds.Rows[Cont]["id"]);
                    producto_id=(int) Ds.Rows[Cont]["producto_id"];
                    especialidad_id=(int) Ds.Rows[Cont]["especialidad_id"];
                    cantidad=Convert.ToInt32(Ds.Rows[Cont]["cantidad"]);
                    descripcion = Ds.Rows[Cont]["descripcion"].ToString();
                    importe_unitario =Convert.ToDecimal(Ds.Rows[Cont]["importe_unitario"]);
                    total =Convert.ToDecimal(Ds.Rows[Cont]["total"]);
                    Status = Convert.ToInt32(Ds.Rows[Cont]["status"]);
                    dgOrdenDetalle.Rows.Add(id, producto_id, especialidad_id, cantidad, descripcion, importe_unitario, total, Status);
                }
                RecalcularTotales();    //Recalculo los totales en el grid
                
            }
                
        }


        private void CargarCliente(int clienteId)
        {            
            pizzasDataSet.clienteDataTable Ds = new pizzasDataSet.clienteDataTable();
            Ds = clienteTableAdapter.GetById(clienteId);
            if (Ds.Count > 0)
            {                
                txtTelefono.Text = Ds.Rows[0]["telefono"].ToString();
                txtNombre.Text = Ds.Rows[0]["nombre"].ToString();
                txtDomicilio.Text = Ds.Rows[0]["domicilio"].ToString();
            }
            else
                txtNombre.Text = "Cliente no encontrado";
        }


        //Borra el renglon seleccionado actual
        private void dgOrdenDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            Int64 detalleId=0;
            if (e.ColumnIndex == 7 && (OrdenStatus== 1))     //SI es la columna Status y el estado de la orden es Abierta
            {
                detalleId = Convert.ToInt64(dgOrdenDetalle.CurrentRow.Cells["id"].Value);
                orden_detalleTableAdapter.DeleteById(detalleId);        //borro de la base de datos
                dgOrdenDetalle.Rows.Remove(dgOrdenDetalle.CurrentRow);  //Borro del grid
                //Actualizo los totales de la orden
                RecalcularTotales();        //Recalculo los totales en el grid a la vez que los guardo en la BD
            }
                
        }


        //Vuelve a calcular los totales
        private void RecalcularTotales()
        {
            int Registros = dgOrdenDetalle.Rows.Count;
            SubTotal = 0;
            for (int Cont = 0; Cont < Registros; Cont++)
            {
                SubTotal = SubTotal + Convert.ToDecimal(dgOrdenDetalle.Rows[Cont].Cells["Total"].Value);
            }
            TotalOrden = SubTotal - Descuento;

            txtSubtotal.Tag = SubTotal.ToString();
            txtSubtotal.Text = SubTotal.ToString();

            txtTotal.Tag = TotalOrden.ToString();
            txtTotal.Text = TotalOrden.ToString();
            GuardarTotales(OrdenId);    //Guardo los totales en la BD
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (txtDescuento.TextLength > 0)
            {
                Descuento = Convert.ToDecimal(txtDescuento.Text);
                RecalcularTotales();
            }
        }        

       
        

        private void FormatearMoneda(object sender, EventArgs e)
        {
            Utils.FormatearMoneda(sender);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cerrandose(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Por que se cierra");
            
        }       

        

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            int Cantidad;
            int Retorno = 0;

            pizzasDataSet.orden_detalleDataTable Ds = new pizzasDataSet.orden_detalleDataTable();

            Cantidad = Convert.ToInt32(txtCantidad.Text);
            if (Cantidad > 0)
            {
                //Guardo el detalle en la BD
                Retorno = Convert.ToInt32(orden_detalleTableAdapter.InsertarOrdenDetalle(OrdenId, ProductoId, EspecialidadId, Cantidad, ProductoDesc, ProductoPrecio, Cantidad * ProductoPrecio));
                if (Retorno == 0)
                {
                    int OrdenDetalleId = 0;
                    OrdenDetalleId = Convert.ToInt32(orden_detalleTableAdapter.GetLastId());        //Obtengo el ultimo insertado                    
                    //Agrego en el grid el detalle recien insertado en la BD
                    dgOrdenDetalle.Rows.Add(OrdenDetalleId, ProductoId, EspecialidadId, txtCantidad.Text, ProductoDesc, ProductoPrecio, Cantidad * ProductoPrecio, 1);

                    //Actualizo los totales de la orden
                    RecalcularTotales();        //Recalculo los totales en el grid a la vez que los guardo en la BD

                }
            }
        }

       

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Imprime nuevamente la orden
            ImprimirTicket(OrdenId);
        }


        //Imprime la orden que se le pase
        private void ImprimirTicket(int ordenId, decimal MontoPago=0)
        {
            Ticket ticket = new Ticket();

            //ticket.HeaderImage = "C:\\Users\\Sergio\\OneDrive\\Pizzas Di Carlo\\Pizzas Di Carlo\\DOCUMENTOS\\logo.jpg"; //esta propiedad no es obligatoria
            //MessageBox.Show("Espere", "Imprimiendo Ticket", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                

            ticket.AddHeaderLine("Num. de Orden: " + ordenId);
            ticket.AddHeaderLine("PIZZAS DI CARLO");            
            ticket.AddHeaderLine("EXPEDIDO EN:");
            ticket.AddHeaderLine("7a. AV. SUR ESQUINA CON 18 OTE.");
            ticket.AddHeaderLine("TAPACHULA, CHIAPAS");
            //ticket.AddHeaderLine("RFC: CSI-020226-MV4");

            //El metodo AddSubHeaderLine es lo mismo al de AddHeaderLine con la diferencia
            //de que al final de cada linea agrega una linea punteada "=========="
                       
            ticket.AddSubHeaderLine("Cliente: " + txtNombre.Text);
            if (ClienteTipo == 3)  //Si es venta a domicilio            
                ticket.AddSubHeaderLine("Direccion: " + txtDomicilio.Text);           
            
            
            //ticket.AddSubHeaderLine("Le atendió: " + Utils.UsuarioNombre);
            //ticket.AddSubHeaderLine("Impresion: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());


            //El metodo AddItem requeire 3 parametros, el primero es cantidad, el segundo es la descripcion
            //del producto y el tercero es el precio
            int Registros = dgOrdenDetalle.Rows.Count;

            int ArticuloCant = 0;
            string ArticuloDesc = "";
            decimal ArticuloTotal = 0;

            ticket.SetEncabezadoColumna("CANT  DESCRIPCION        IMPORTE");

            for (int Cont = 0; Cont < Registros; Cont++)
            {
                ArticuloCant = Convert.ToInt32(dgOrdenDetalle.Rows[Cont].Cells["Cantidad"].Value);
                ArticuloDesc = dgOrdenDetalle.Rows[Cont].Cells["Descripcion"].Value.ToString();
                ArticuloTotal = Convert.ToDecimal(dgOrdenDetalle.Rows[Cont].Cells["Total"].Value);
                ticket.AddItem(String.Format("{0:N0}", ArticuloCant), ArticuloDesc, String.Format("{0:N2}", ArticuloTotal));
            }


            //El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio
            ticket.AddTotal("SUBTOTAL", String.Format("{0:N2}", SubTotal));
            ticket.AddTotal("DESCUENTO", String.Format("{0:N2}", Descuento));            
            ticket.AddTotal("TOTAL", txtTotal.Text);
            if (MontoPago > 0)
            {
                ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
                ticket.AddTotal("RECIBIDO", String.Format("{0:N2}", MontoPago));
                ticket.AddTotal("CAMBIO", String.Format("{0:N2}", MontoPago - TotalOrden));
            }

            ticket.AddTotal("", "");   //Ponemos un total en blanco que sirve de espacio                                   
            //El metodo AddFooterLine funciona igual que la cabecera            
            ticket.AddFooterLine("Le atendió: " + Utils.UsuarioNombre);
            ticket.AddFooterLine("Impresion: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            ticket.AddFooterLine("");
            ticket.AddFooterLine("Vuelva pronto a Pizzas Di Carlo");
            ticket.AddFooterLine("¡¡GRACIAS POR TU VISITA!!");

            //Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un
            //parametro de tipo string que debe de ser el nombre de la impresora.
            ticket.PrintTicket();            

        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
      
    }
}
