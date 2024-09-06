using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cajero_automatico
{
    public partial class FrmIniciarSesionAdministrador : Form
    {
        private bool validado = false;
        public FrmIniciarSesionAdministrador()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            this.ShowDialog();
            return validado;
        }
        private void Control_Validating(object sender, CancelEventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
            if (string.IsNullOrEmpty(((TextBox)sender).Text) == false)
            {
                ErrNotificador.SetError((TextBox)sender, "");
            }
            else
            {
                ErrNotificador.SetError((TextBox)sender, "Llene este campo");
                e.Cancel = true;
            }
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (TxtUsuario.Text.Equals(Program.administrador.Usuario) && TxtContrasenia.Text.Equals(TxtContrasenia.Text))
                {
                    validado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Clave incorrectas", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
