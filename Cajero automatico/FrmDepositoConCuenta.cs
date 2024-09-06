using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cajero_automatico
{
    public partial class FrmDepositoConCuenta : Form
    {
        private CuentaBancaria cuentaDepositar = new CuentaBancaria();

        public FrmDepositoConCuenta()
        {
            InitializeComponent();
        }

        private void FrmDepositoConCuenta_Load(object sender, EventArgs e)
        {
            var encontrados = BuscarCuentas();
            if (encontrados.Count > 0)
            {
                CboCuentas.DisplayMember = "Numero";
                CboCuentas.DataSource = encontrados;
            }
            CboCuentas.SelectedIndex = -1;
            ChkUnaDeMisCuentas.Checked = true;
        }

        private List<CuentaBancaria> BuscarCuentas()
        {
            var encontrados = new List<CuentaBancaria>();

            encontrados = (from cuenta in Program.cuentasBancarias
                           where cuenta.Cliente == Program.sesionCliente
                           select cuenta).ToList();
            return encontrados;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChkUnaDeMisCuentas_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkUnaDeMisCuentas.Checked)
            {
                CboCuentas.Enabled = true;
                TxtNumeroCuenta.Enabled = false;
                BtnBuscar.Enabled = false;
            }
            else
            {
                CboCuentas.SelectedIndex = -1;
                CboCuentas.Enabled = false;
                TxtNumeroCuenta.Enabled = true;
                BtnBuscar.Enabled = true;
            }
            BorrarErrores();
        }

        private void BorrarErrores()
        {
            ErrNotificador.SetError(CboCuentas, "");
            ErrNotificador.SetError(TxtNumeroCuenta, "");
        }

        private void CboCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCuentas.SelectedIndex > -1)
            {
                var cuenta = (CuentaBancaria)CboCuentas.SelectedItem;
                cuentaDepositar = cuenta;
                TxtTipoMonedaMisCuentas.Text = cuenta.NombreTipoMoneda;
                LblMontoTotal.Text = cuentaDepositar.Tipo.Equals("S") ? "Monto total S/" : "Monto total $";
            }
        }

        private void CboCuentas_Validating(object sender, CancelEventArgs e)
        {
            if (ChkUnaDeMisCuentas.Checked == true)
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
        }

        private void TxtControl_Validating(object sender, CancelEventArgs e)
        {
            if (ChkUnaDeMisCuentas.Checked == false)
            {
                ((Control)sender).Text = ((Control)sender).Text.Trim();
                if (string.IsNullOrEmpty(((Control)sender).Text) == false)
                {
                    ErrNotificador.SetError((Control)sender, "");

                    if (((Control)sender).Name.Equals("TxtNumero") && TxtNumeroCuenta.Text.Length < 10)
                    {
                        ErrNotificador.SetError(TxtNumeroCuenta, "El número de cuenta debe tener 10 caracteres como mínimo");
                        e.Cancel = true;
                    }
                }
                else
                {
                    ErrNotificador.SetError((Control)sender, "Este campo es obligatorio");
                    e.Cancel = true;
                }
            }
        }

        private void TxtMontoTotal_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMontoTotal.Text))
            {
                ErrNotificador.SetError(TxtMontoTotal, "El depósito mínimo es de 20 soles");
                e.Cancel = true;
            }
            else
            {
                ErrNotificador.SetError((Control)sender, "");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ErrNotificador.SetError(TxtNumeroCuenta, "");
            if (TxtNumeroCuenta.Text.Length == 0)
            {
                ErrNotificador.SetError(TxtNumeroCuenta, "Ingrese un número de cuenta");
                return;
            }

            if (TxtNumeroCuenta.Text.Length < 10)
            {
                ErrNotificador.SetError(TxtNumeroCuenta, "El número de cuenta debe tener 10 caracteres como mínimo");
                return;
            }

            cuentaDepositar = (from cuenta in Program.cuentasBancarias
                               where cuenta.Numero.Equals(TxtNumeroCuenta.Text)
                               select cuenta).FirstOrDefault();

            if (cuentaDepositar == null)
            {
                MessageBox.Show("Número de cuenta no encotrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TxtNombre.Text = cuentaDepositar.Cliente.NombreCompleto;
                TxtTipoMoneda.Text = cuentaDepositar.NombreTipoMoneda;
                LblMontoTotal.Text = cuentaDepositar.Tipo.Equals("S") ? "Monto total S/" : "Monto total $";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {
                var depositoSinCuenta = new DepositoConCuenta()
                {
                    CuentaDestino = cuentaDepositar,
                    Cliente = Program.sesionCliente,
                    Fecha = DateTime.Now,
                    Monto = double.Parse(TxtMontoTotal.Text)
                };

                Program.operaciones.Add(depositoSinCuenta);

                foreach (var cuenta in Program.cuentasBancarias)
                {
                    if (cuenta.Equals(cuentaDepositar))
                    {
                        cuenta.Saldo += double.Parse(TxtMontoTotal.Text);
                    }
                }
                var montoAgregar = (int)NudBillete20.Value * 20 + (int)NudBillete50.Value * 50 + (int)NudBillete100.Value * 100;

                if (cuentaDepositar.Tipo.Equals("S"))
                {
                    Program.cajero.DineroSoles.CantidadBillete20 += (int)NudBillete20.Value;
                    Program.cajero.DineroSoles.CantidadBillete50 += (int)NudBillete50.Value;
                    Program.cajero.DineroSoles.CantidadBillete100 += (int)NudBillete100.Value;
                    Program.cajero.DineroSoles.MontoTotal += montoAgregar;
                }
                else
                {
                    Program.cajero.DineroDolares.CantidadBillete20 += (int)NudBillete20.Value;
                    Program.cajero.DineroDolares.CantidadBillete50 += (int)NudBillete50.Value;
                    Program.cajero.DineroDolares.CantidadBillete100 += (int)NudBillete100.Value;
                    Program.cajero.DineroDolares.MontoTotal += montoAgregar;
                }
                MessageBox.Show($"Depósito realizado con éxito.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerarVaucher();
            }
        }

        public void GenerarVaucher()
        {
            var ruta = $"{Program.rutaGuardar}DepositoConCuenta_{Program.sesionCliente.Dni}_{cuentaDepositar.Numero}_{DateTime.Now:ddMMyyHHmmss}.pdf";
            FileStream fs = new FileStream(@ruta, FileMode.Create);

            Document doc = new Document(PageSize.A7, 10, 10, 40, 20);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.AddTitle("Voucher deposito con cuenta");
            doc.AddCreator("Cajero automatico");

            doc.Open();

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            doc.Add(new Paragraph($"CAJERO UNPRG", _standardFont) { Alignment = Element.ALIGN_RIGHT });
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("DEPÓSITO CON CUENTA", _standardFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph($"FECHA: {DateTime.Now}", _standardFont) { Alignment = Element.ALIGN_RIGHT });
            doc.Add(Chunk.NEWLINE);

            PdfPTable tabla = new PdfPTable(2);
            tabla.WidthPercentage = 100;

            PdfPCell cell = new PdfPCell(new Phrase(cuentaDepositar.Cliente.NombreCompleto.ToUpper(), _standardFont));
            cell.Colspan = 3;
            cell.BorderWidth = 0;
            tabla.AddCell(cell);

            cell = new PdfPCell(new Phrase($"NUMERO CUENTA: {cuentaDepositar.Numero}", _standardFont));
            cell.Colspan = 3;
            cell.BorderWidth = 0;
            tabla.AddCell(cell);

            cell = new PdfPCell(new Phrase($"REMITENTE: {Program.sesionCliente.NombreCompleto}", _standardFont));
            cell.Colspan = 3;
            cell.BorderWidth = 0;
            tabla.AddCell(cell);

            cell = new PdfPCell(new Phrase("\n", _standardFont));
            cell.Colspan = 3;
            cell.BorderWidth = 0;
            tabla.AddCell(cell);

            PdfPCell clItem1 = new PdfPCell(new Phrase("IMPORTE DEPOSITADO:", _standardFont));
            clItem1.BorderWidth = 0;
            PdfPCell clItem2 = new PdfPCell(new Phrase("\n" + DineroMostrar(TxtMontoTotal.Text), _standardFont));
            clItem2.BorderWidth = 0;
            tabla.AddCell(clItem1);
            tabla.AddCell(clItem2);

            doc.Add(tabla);

            doc.Close();
            writer.Close();
            System.Diagnostics.Process.Start(ruta);
        }

        private string DineroMostrar(string monto)
        {
            string montoMostrar = "";
            if (cuentaDepositar.Tipo.Equals("S"))
            {
                var cant = 13 - monto.Length;
                string asterisco = "";
                for (int i = 0; i < cant; i++)
                {
                    asterisco = $"{asterisco}*";
                }
                montoMostrar = $"S/{asterisco}{monto}";
            }
            else
            {
                var cant = 14 - monto.Length;
                string asterisco = "";
                for (int i = 0; i < cant; i++)
                {
                    asterisco = $"{asterisco}*";
                }
                montoMostrar = $"${asterisco}{monto}";
            }
            return montoMostrar;
        }

        private void CalcularMontoTotal()
        {
            decimal total = NudMontoBillete20.Value + NudMontoBillete50.Value + NudMontoBillete100.Value;
            TxtMontoTotal.Text = total.ToString();
        }

        private void NudBillete20_KeyPress(object sender, KeyPressEventArgs e)
        {
            NudMontoBillete20.Value = NudBillete20.Value * 20;
            CalcularMontoTotal();
        }

        private void NudBillete50_KeyPress(object sender, KeyPressEventArgs e)
        {
            NudMontoBillete50.Value = NudBillete50.Value * 50;
            CalcularMontoTotal();
        }

        private void NudBillete100_KeyPress(object sender, KeyPressEventArgs e)
        {
            NudMontoBillete100.Value = NudBillete100.Value * 100;
            CalcularMontoTotal();
        }

        private void NudBillete20_ValueChanged(object sender, EventArgs e)
        {
            NudMontoBillete20.Value = NudBillete20.Value * 20;
            CalcularMontoTotal();
        }

        private void NudBillete50_ValueChanged(object sender, EventArgs e)
        {
            NudMontoBillete50.Value = NudBillete50.Value * 50;
            CalcularMontoTotal();
        }

        private void NudBillete100_ValueChanged(object sender, EventArgs e)
        {
            NudMontoBillete100.Value = NudBillete100.Value * 100;
            CalcularMontoTotal();
        }


    }

}
