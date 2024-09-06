using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cajero_automatico
{
    public partial class FrmCuentaBancaria : Form
    {
        private CuentaBancaria Actual;
        public FrmCuentaBancaria()
        {
            InitializeComponent();
        }

        private void FrmCuenta_Load(object sender, EventArgs e)
        {
            if (Program.clientes.Count > 0)
            {
                CboCliente.DisplayMember = "NombreCompleto";
                CboCliente.DataSource = Program.clientes;
            }
            LimpiarControles();
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
                CboCliente.Focus();
            }
        }

        private void LimpiarControles()
        {
            CboCliente.SelectedIndex = -1;
            TxtNumero.Text = "";
            TxtCCI.Text = "";
            CboTipoMoneda.SelectedIndex = -1;
            NudSaldo.Value = NudSaldo.Minimum;
            ChkVigente.Checked = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            LimpiarControles();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            CuentaBancaria cuentaBancaria;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    cuentaBancaria = new CuentaBancaria();
                    Program.cuentasBancarias.Add(cuentaBancaria);
                }
                else
                {
                    cuentaBancaria = this.Actual;
                }
                cuentaBancaria.Cliente = (Cliente)CboCliente.SelectedItem;
                cuentaBancaria.Numero = TxtNumero.Text;
                cuentaBancaria.CCI = TxtCCI.Text;
                cuentaBancaria.Tipo = CboTipoMoneda.Text.Substring(0, 1);
                cuentaBancaria.Saldo = (double)NudSaldo.Value;
                cuentaBancaria.Vigente = ChkVigente.Checked;

                this.ActivarControles(false);
                LimpiarControles();
                BtnListar.PerformClick();
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            DgvListado.DataSource = null;

            if (Program.cuentasBancarias.Count > 0)
            {
                DgvListado.AutoGenerateColumns = false;
                DgvListado.DataSource = Program.cuentasBancarias;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.Actual = (CuentaBancaria)DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cuenta bancaria", this.Text);
            }
        }

        private void PresentarDatos()
        {
            CboCliente.Text = Actual.Cliente.NombreCompleto;
            TxtNumero.Text = Actual.Numero;
            TxtCCI.Text = Actual.CCI;
            CboTipoMoneda.SelectedIndex = "SDM".IndexOf(Actual.Tipo);
            NudSaldo.Value = (decimal)Actual.Saldo;

            this.ActivarControles(true);
        }

        private void TxtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = SoloNumeros(e);
        }

        private bool SoloNumeros(KeyPressEventArgs e)
        {
            return !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void CboTipoMoneda_Validating(object sender, CancelEventArgs e)
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

        private void TxtNumero_Validating(object sender, CancelEventArgs e)
        {
            ((Control)sender).Text = ((Control)sender).Text.Trim();
            if (string.IsNullOrEmpty(((Control)sender).Text) == false)
            {
                ErrNotificador.SetError((Control)sender, "");

                if (((Control)sender).Name.Equals("TxtNumero") && TxtNumero.Text.Length < 10)
                {
                    ErrNotificador.SetError(TxtNumero, "El número de cuenta debe tener 10 caracteres como mínimo.");
                    e.Cancel = true;
                }

                if (((Control)sender).Name.Equals("TxtCCI") && TxtCCI.Text.Length != 20)
                {
                    ErrNotificador.SetError(TxtCCI, "El CCI debe tener 20 caracteres.");
                    e.Cancel = true;
                }
            }
            else
            {
                ErrNotificador.SetError((Control)sender, "Este campo es obligatorio.");
                e.Cancel = true;
            }
        }
    }
}
