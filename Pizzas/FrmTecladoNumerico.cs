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
    public partial class FrmTecladoNumerico : Form
    {
        public string Numero="";
        int MaxLen = 0;

        public FrmTecladoNumerico(int maxLen=10)
        {
            this.MaxLen = maxLen;
            InitializeComponent();
        }
        

        private void FrmTecladoNumerico_Load(object sender, EventArgs e)
        {
            txtNumero.MaxLength = this.MaxLen;
            Numero = "";
            txtNumero.Focus();
        }
        

        //Se activa al teclear cualquier numero
        private void EscribirTecla(object sender, EventArgs e)
        {
            if (MaxLen > 0)    //Si hay un limite de caracteres
                if (txtNumero.TextLength >= MaxLen) //Si se sobrepasa el  numero de caracteres
                    return;

            Button Tecla = (Button)sender;            
            txtNumero.Text += Tecla.Text;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Numero = "";
            Close();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Numero = txtNumero.Text;
            Close();
        }
    }
}
