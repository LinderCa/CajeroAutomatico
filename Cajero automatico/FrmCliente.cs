using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cajero_automatico
{
    public partial class FrmCliente : Form
    {
        private Cliente Actual;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Actual = null;
            ActivarControles(true);
            LimpiarControles();
        }

        private void ActivarControles(bool estado)
        {
            GbEntidad.Enabled = estado;
            GbListado.Enabled = !estado;
            if (estado)
            {
                TxtNombres.Focus();
            }
        }

        private void LimpiarControles()
        {
            TxtNombres.Text = "";
            TxtApPaterno.Text = "";
            TxtApMaterno.Text = "";
            CboGenero.SelectedIndex = -1;
            TxtDni.Text = "";
            TxtContrasenia.Text = "";
            ChkVigente.Checked = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            LimpiarControles();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Cliente usuario;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    usuario = new Cliente();
                    Program.clientes.Add(usuario);
                }
                else
                {
                    usuario = this.Actual;
                }
                usuario.Nombres = TxtNombres.Text;
                usuario.ApellidoPaterno = TxtApPaterno.Text;
                usuario.ApellidoMaterno = TxtApMaterno.Text;
                usuario.Genero = CboGenero.Text.Substring(0, 1);
                usuario.Dni = TxtDni.Text;
                usuario.Contrasenia = TxtContrasenia.Text;
                usuario.Vigente = ChkVigente.Checked;

                this.ActivarControles(false);
                LimpiarControles();
                BtnListar.PerformClick();
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            DgvListado.DataSource = null;

            if (Program.clientes.Count > 0)
            {
                DgvListado.AutoGenerateColumns = false;
                DgvListado.DataSource = Program.clientes;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.Actual = (Cliente)DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario", this.Text);
            }
        }

        private void PresentarDatos()
        {
            TxtNombres.Text = Actual.Nombres;
            TxtApPaterno.Text = Actual.ApellidoPaterno;
            TxtApMaterno.Text = Actual.ApellidoMaterno;
            CboGenero.SelectedIndex = "FM".IndexOf(Actual.Genero);
            TxtDni.Text = Actual.Dni;
            TxtContrasenia.Text = Actual.Contrasenia;
            ChkVigente.Checked = Actual.Vigente;

            this.ActivarControles(true);
        }

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = SoloNumeros(e);
        }

        private bool SoloNumeros(KeyPressEventArgs e)
        {
            return !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void Control_Validating(object sender, CancelEventArgs e)
        {
            ((Control)sender).Text = ((Control)sender).Text.Trim();
            if (string.IsNullOrEmpty(((Control)sender).Text) == false)
            {
                ErrNotificador.SetError((Control)sender, "");

                if (((Control)sender).Name.Equals("TxtDni") && TxtDni.Text.Length != 8)
                {
                    ErrNotificador.SetError(TxtDni, "El DNI debe tener 8 caracteres.");
                    e.Cancel = true;
                }

                if (((Control)sender).Name.Equals("TxtContrasenia") && TxtContrasenia.Text.Length < 8)
                {
                    ErrNotificador.SetError(TxtContrasenia, "El contraseña debe tener 8 caracteres como mínimo.");
                    e.Cancel = true;
                }
            }
            else
            {
                ErrNotificador.SetError((Control)sender, "Este campo es obligatorio.");
                e.Cancel = true;
            }
        }

        private void CboGenero_Validating(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex > -1)
            {
                ErrNotificador.SetError((Control)sender, "");
            }
            else
            {
                ErrNotificador.SetError((Control)sender, "Debe realizar una selección.");
                e.Cancel = true;
            }
        }

        private void TxtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
