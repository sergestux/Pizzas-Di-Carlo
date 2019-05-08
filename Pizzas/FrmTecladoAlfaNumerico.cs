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
    public partial class FrmTecladoAlfaNumerico : Form
    {
        public string Texto="";
        private bool Mayusc = true;         //Mayusculas activadas por default
        private bool Password = false;      //Indico si es una caja de password donde no se podran ver los caracteres

        public FrmTecladoAlfaNumerico(string texto="", bool password=false)
        {
            this.Texto = texto;
            this.Password = password;
            InitializeComponent();
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Texto = "";
            Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Texto = txtTexto.Text;
            Close();
        }



        private void FrmTecladoAlfaNumerico_Load(object sender, EventArgs e)
        {
            
            if (this.Password)
                txtTexto.PasswordChar = '*';
            this.txtTexto.Text = Texto;
            //txtTexto.Focus();
        }


        //Escribe la tecla, tecleada
        private void EscribirTecla(object sender, EventArgs e)
        {
            bool TeclaEspecial = false;     //Indico si una tecla especial fue presionada
            Button Tecla = (Button) sender;
            string Letra = "";
            
            if (Tecla.Tag.ToString() == "Shift")
            {
                Mayusc = !(Mayusc);     //Desactivo o activo las mayusculas segun sea el caso
                toolTip1.ShowAlways = Mayusc;   //Muestro el tooltip
                TeclaEspecial = true;   //Indico que es una tecla especial que no debe escribirse

                if (Mayusc == false)
                    Tecla.BackColor = Color.Transparent;
                else
                {
                    Tecla.BackColor = Color.Black;                    
                    toolTip1.Show("Bloque de Mayusculas Activados", btnShift);
                }
                ConvertirTeclado(Mayusc);   //Convierto el teclado
                
            }

            if (Tecla.Tag.ToString() == "Borrar")
            {
                TeclaEspecial = true;
                if(txtTexto.TextLength>0)
                    txtTexto.Text = txtTexto.Text.Remove(txtTexto.TextLength-1);
            }

            //Si la tecla puede mostrarse
            if (!TeclaEspecial)
            {                
                Letra = Tecla.Text;
                if (Tecla.Tag.ToString() == "Espacio")
                    Letra = " ";                
                txtTexto.Text = txtTexto.Text + Letra;
            }
        }

        private void ConvertirTeclado(bool Mayusc)
        {

            foreach (var control in panelLetras.Controls)
            {
                Button Boton = control as Button;

                if (Boton.Tag.ToString()=="Letra")  //Si es una letra
                {
                    if (Mayusc)
                        Boton.Text=Boton.Text.ToUpper();
                    else
                        Boton.Text=Boton.Text.ToLower();    
                }
            }
        }

        
    }
}
