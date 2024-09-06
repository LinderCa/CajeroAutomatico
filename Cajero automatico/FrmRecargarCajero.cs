using System;
using System.Windows.Forms;

namespace Cajero_automatico
{
    public partial class FrmRecargarCajero : Form
    {
        public FrmRecargarCajero()
        {
            InitializeComponent();
        }

        private void FrmIniarCajero_Load(object sender, EventArgs e)
        {
            TxtActualSoles.Text = Program.cajero.DineroSoles.MontoTotal.ToString();
            TxtActualDolares.Text = Program.cajero.DineroDolares.MontoTotal.ToString();
            TxtMontoTotalIngresarSoles.Text = "0";
            TxtMontoTotalIngresarDolares.Text = "0";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtActualSoles.Text.Equals(TxtMontoTotalSoles.Text) && TxtActualDolares.Text.Equals(TxtMontoTotalDolares.Text))
            {
                MessageBox.Show("No ha ingresado dinero para realizar la recarga", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.cajero.DineroSoles.CantidadBillete20 += (int)NudMontoBillete20Soles.Value;
                Program.cajero.DineroSoles.CantidadBillete50 += (int)NudMontoBillete50Soles.Value;
                Program.cajero.DineroSoles.CantidadBillete100 += (int)NudMontoBillete100Soles.Value;

                Program.cajero.DineroDolares.CantidadBillete20 += (int)NudMontoBillete20Dolares.Value;
                Program.cajero.DineroDolares.CantidadBillete50 += (int)NudMontoBillete50Dolares.Value;
                Program.cajero.DineroDolares.CantidadBillete100 += (int)NudMontoBillete100Dolares.Value;

                Program.cajero.DineroSoles.MontoTotal = Int32.Parse(TxtMontoTotalSoles.Text);
                Program.cajero.DineroDolares.MontoTotal = Int32.Parse(TxtMontoTotalDolares.Text);
                MessageBox.Show("Recarga del cajero realizada con éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CalcularMontoTotalSoles()
        {
            decimal total = NudMontoBillete20Soles.Value + NudMontoBillete50Soles.Value + NudMontoBillete100Soles.Value;
            TxtMontoTotalIngresarSoles.Text = total.ToString();
        }

        private void CalcularMontoTotalDolares()
        {
            decimal total = NudMontoBillete20Dolares.Value + NudMontoBillete50Dolares.Value + NudMontoBillete100Dolares.Value;
            TxtMontoTotalIngresarDolares.Text = total.ToString();
        }

        private void NudBillete20Soles_KeyUp(object sender, KeyEventArgs e)
        {
            NudMontoBillete20Soles.Value = NudBillete20Soles.Value * 20;
            CalcularMontoTotalSoles();
        }

        private void NudBillete20Soles_ValueChanged(object sender, EventArgs e)
        {
            NudMontoBillete20Soles.Value = NudBillete20Soles.Value * 20;
            CalcularMontoTotalSoles();
        }

        private void NudBillete50Soles_KeyUp(object sender, KeyEventArgs e)
        {
            NudMontoBillete50Soles.Value = NudBillete50Soles.Value * 50;
            CalcularMontoTotalSoles();
        }

        private void NudBillete50Soles_ValueChanged(object sender, EventArgs e)
        {
            NudMontoBillete50Soles.Value = NudBillete50Soles.Value * 50;
            CalcularMontoTotalSoles();
        }

        private void NudBillete100Soles_ValueChanged(object sender, EventArgs e)
        {
            NudMontoBillete100Soles.Value = NudBillete100Soles.Value * 100;
            CalcularMontoTotalSoles();
        }

        private void NudBillete100Soles_KeyUp(object sender, KeyEventArgs e)
        {
            NudMontoBillete100Soles.Value = NudBillete100Soles.Value * 100;
            CalcularMontoTotalSoles();
        }

        private void NudBillete20Dolares_KeyUp(object sender, KeyEventArgs e)
        {
            NudMontoBillete20Dolares.Value = NudBillete20Dolares.Value * 20;
            CalcularMontoTotalDolares();
        }

        private void NudBillete20Dolares_ValueChanged(object sender, EventArgs e)
        {
            NudMontoBillete20Dolares.Value = NudBillete20Dolares.Value * 20;
            CalcularMontoTotalDolares();
        }

        private void NudBillete50Dolares_ValueChanged(object sender, EventArgs e)
        {
            NudMontoBillete50Dolares.Value = NudBillete50Dolares.Value * 50;
            CalcularMontoTotalDolares();
        }

        private void NudBillete50Dolares_KeyUp(object sender, KeyEventArgs e)
        {
            NudMontoBillete50Dolares.Value = NudBillete50Dolares.Value * 50;
            CalcularMontoTotalDolares();
        }

        private void NudBillete100Dolares_KeyUp(object sender, KeyEventArgs e)
        {
            NudMontoBillete100Dolares.Value = NudBillete100Dolares.Value * 100;
            CalcularMontoTotalDolares();
        }

        private void NudBillete100Dolares_ValueChanged(object sender, EventArgs e)
        {
            NudMontoBillete100Dolares.Value = NudBillete100Dolares.Value * 100;
            CalcularMontoTotalDolares();
        }

        private void TxtMontoTotalIngresarSoles_TextChanged(object sender, EventArgs e)
        {
            TxtMontoTotalSoles.Text = (double.Parse(TxtMontoTotalIngresarSoles.Text) + Program.cajero.DineroSoles.MontoTotal).ToString();
        }

        private void TxtMontoTotalIngresarDolares_TextChanged(object sender, EventArgs e)
        {
            TxtMontoTotalDolares.Text = (double.Parse(TxtMontoTotalIngresarDolares.Text) + Program.cajero.DineroDolares.MontoTotal).ToString();
        }
    }
}
