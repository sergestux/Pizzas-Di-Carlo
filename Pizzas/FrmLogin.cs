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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    //Cierra el formulario y por lo tanto la aplicación            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                if (UsuarioValido(txtUsuario.Text, txtPassword.Text))
                {
                    this.Visible = false;
                    FrmMain Frm = new FrmMain();
                    Frm.ShowDialog();                    
                    this.Close();
                }
                else
                    MessageBox.Show("DATOS DE ACCESO INCORRECTO","ERROR AL INICIAR SESION");
            }
            else
                MessageBox.Show("FALTAN DATOS", "VUELVA A INTENTARLO");
        }

        //Verifica que haya clave y password
        private bool ValidarDatos()
        {
            bool Retorno = true;
            if (txtUsuario.TextLength == 0)
                Retorno = false;            
            if (txtPassword.TextLength == 0)
                Retorno = false;

            return Retorno;
        }


        //Regresa si el usuario y clave que se le pase son  validos
        //Si son validos, almacena el tipo de usuario en la clase Utils
        private bool UsuarioValido(string Usuario, string Clave)
        {
            bool Retorno = false;            
            pizzasDataSet.usuarioDataTable Ds = new pizzasDataSet.usuarioDataTable();
            
            Ds =usuarioTableAdapter.GetUsuarioValido(Usuario, Clave);
            int CantRegistros = Ds.Count;
            if (CantRegistros > 0)
            {
                Utils.UsuarioId=Convert.ToInt32(Ds.Rows[0]["id"]);
                Utils.UsuarioTipo = Convert.ToInt32(Ds.Rows[0]["perfil"]);
                Utils.UsuarioNombre = Ds.Rows[0]["nombre"].ToString();
                Retorno = true;     //Indico que si es un usuario Valido
            }
            return Retorno;
        }


        private void TecladoAlfanumerico(object sender, EventArgs e)
        {
            Utils.TecladoAlfaNumerico(sender);
        }

        private void TecladoAlfanumericoPassword(object sender, EventArgs e)
        {
            Utils.TecladoAlfaNumerico(sender, true);
        }


    }
}
