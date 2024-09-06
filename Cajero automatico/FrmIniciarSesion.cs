using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Cajero_automatico
{
    public partial class FrmIniciarSesion : Form
    {
        private Cliente encontrado;
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        public Cliente Buscar()
        {
            this.ShowDialog();
            return encontrado;
        }

        private void TxtDni_Validating(object sender, CancelEventArgs e)
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
                var clienteValidado = (from cliente in Program.clientes
                                       where cliente.Dni.Equals(TxtDni.Text) && cliente.Contrasenia.Equals(TxtContrasenia.Text)
                                             && cliente.Vigente == true
                                       select cliente).FirstOrDefault();

                if (clienteValidado == null)
                {
                    MessageBox.Show("Usuario o Clave incorrectas", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    encontrado = clienteValidado;
                    this.Close();
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
