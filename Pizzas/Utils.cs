using System;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizzas
{
    class Utils
    {
        private static string Impresora = "";
        public static Int32 UsuarioId= 0;
        public static Int32 UsuarioTipo = 0;
        public static string UsuarioNombre =""; 

        //Prepara la impresora para tickets
        public static void SetImpresoraPorDefecto(String impresora="")
        {
            if (impresora == "")
                Impresora = getImpresoraPorDefecto();
        }

        
        public static string getImpresora()
        {
            return Impresora;
        }

        
        //Muestra el teclado numerico y lo asigna en el objeto que lo llamó
        public static void TecladoNumerico(object sender) 
        {
            TextBox CajaTexto = (TextBox)sender;
            FrmTecladoNumerico Frm = new FrmTecladoNumerico();
            Frm.ShowDialog();
            if(Frm.Numero.Length > 0)
                CajaTexto.Text = Frm.Numero.ToString(); 
        }

        //Muestra el teclado AlfaNumerico y lo asigna en el objeto que lo llamó
        public static void TecladoAlfaNumerico(object sender, bool password=false)
        {
            TextBox CajaTexto = (TextBox)sender;
            FrmTecladoAlfaNumerico Frm = new FrmTecladoAlfaNumerico(CajaTexto.Text, password);
            Frm.ShowDialog();
            if (Frm.Texto !="")
                CajaTexto.Text = Frm.Texto;
        }


        //Genera la orden y la asigna al cliente que se le pase, regresa el numero de orden generado
        public static int GenerarOrden(int ClienteId, int UsuarioId, int TipoVenta)
        {
            int OrdenGenerada = 0;
            int Result = 0;
            pizzasDataSetTableAdapters.ordenTableAdapter TablaOrden = new pizzasDataSetTableAdapters.ordenTableAdapter();
            //TablaOrden.Insert(ClienteId, 
            Result= (int) TablaOrden.Generar(ClienteId, UsuarioId, TipoVenta);
            if (Result == 1)
                OrdenGenerada =Convert.ToInt32(TablaOrden.getLastId());
            return OrdenGenerada;
        }


        //Formatea la caja de texto a dos decimales que se le pase
        public static void FormatearMoneda(object Caja)
        {
            TextBox CajaTexto = (TextBox)Caja;
            CajaTexto.Text = string.Format("{0:C2}", Convert.ToDecimal(CajaTexto.Tag));
            CajaTexto.TextAlign = HorizontalAlignment.Right;    //Alineamos a Label izquierda
            //tb.Text = string.Format("{0:c2}", numero);
        }


        public static string NumLetras(double value)
        {

            string Num2Text = "";

            string[] UNIDADES = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE" };

            value = Math.Truncate(value);

            if ((value >= 0) && (value <= 15))
                Num2Text = UNIDADES[Convert.ToInt16(value)];
            else if (value < 20)
                Num2Text = "DIECI" + NumLetras(value - 10);
            else if (value == 20) Num2Text = "VEINTE";

            else if (value < 30)
            {

                string segundaCifra;

                if ((value % 20).Equals(1))
                    segundaCifra = "UN";
                else
                    segundaCifra = NumLetras(value % 20);

                Num2Text = "VEINTI" + segundaCifra;

            }

            else if (value == 30) Num2Text = "TREINTA";

            else if (value == 40) Num2Text = "CUARENTA";

            else if (value == 50) Num2Text = "CINCUENTA";

            else if (value == 60) Num2Text = "SESENTA";

            else if (value == 70) Num2Text = "SETENTA";

            else if (value == 80) Num2Text = "OCHENTA";

            else if (value == 90) Num2Text = "NOVENTA";

            else if (value < 100)
            {

                string segundaCifra;

                if ((value % 10).Equals(1))
                {

                    segundaCifra = "UN";

                }

                else
                {

                    segundaCifra = NumLetras(value % 10);

                }

                Num2Text = NumLetras(Math.Truncate(value / 10) * 10) + " Y " + segundaCifra;

            }

            else if (value == 100) Num2Text = "CIEN";

            else if (value < 200) Num2Text = "CIENTO " + NumLetras(value - 100);

            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = NumLetras(Math.Truncate(value / 100)) + "CIENTOS";

            else if (value == 500) Num2Text = "QUINIENTOS";

            else if (value == 700) Num2Text = "SETECIENTOS";

            else if (value == 900) Num2Text = "NOVECIENTOS";

            else if (value < 1000) Num2Text = NumLetras(Math.Truncate(value / 100) * 100) + " " + NumLetras(value % 100);

            else if (value == 1000) Num2Text = "MIL";

            else if (value < 2000) Num2Text = "MIL " + NumLetras(value % 1000);

            else if (value < 1000000)
            {

                Num2Text = NumLetras(Math.Truncate(value / 1000)) + " MIL";

                if ((value % 1000) > 0)
                {

                    Num2Text = Num2Text + " " + NumLetras(value % 1000);

                }

            }

            else if (value == 1000000) Num2Text = "UN MILLON";

            else if (value < 2000000) Num2Text = "UN MILLON " + NumLetras(value % 1000000);

            else if (value < 1000000000000)
            {

                Num2Text = NumLetras(Math.Truncate(value / 1000000)) + " MILLONES ";

                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0)
                {

                    Num2Text = Num2Text + " " + NumLetras(value - Math.Truncate(value / 1000000) * 1000000);

                }

            }

            else if (value == 1000000000000)
            {

                Num2Text = "UN BILLON";

            }

            else if (value < 2000000000000)
            {

                Num2Text = "UN BILLON " + NumLetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            }

            else
            {

                Num2Text = NumLetras(Math.Truncate(value / 1000000000000)) + " BILLONES";

                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0)
                {

                    Num2Text = Num2Text + " " + NumLetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);

                }

            }

            return Num2Text;

        }


        /*
         * Retorna la impresora por defecto en la maquina local
         * Requerimiento
         * using System.Drawing.Printing;
         */
        private static string getImpresoraPorDefecto()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }


        


    }
}
