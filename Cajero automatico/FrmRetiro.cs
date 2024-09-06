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
    public partial class FrmRetiro : Form
    {
        private int C100 = 0;
        private int C50 = 0;
        private int C20 = 0;
        private CuentaBancaria cuentaRetiro = new CuentaBancaria();

        public FrmRetiro()
        {
            InitializeComponent();
        }

        private void BtnOtroMonto_Click(object sender, EventArgs e)
        {
            NudOtroMonto.Enabled = true;
            BtnConfirmar.Enabled = true;
            LblMaximo.Enabled = true;
            LblOtroMonto.Enabled = true;
            TxtMonto.Text = "0";
            Btn20.Enabled = false;
            Btn50.Enabled = false;
            Btn100.Enabled = false;
            Btn200.Enabled = false;
            Btn500.Enabled = false;
            Btn3000.Enabled = false;
        }

        private void FrmRetiro_Load(object sender, EventArgs e)
        {
            TxtMonto.Text = "0";
        }

        private void Btn20_Click(object sender, EventArgs e)
        {
            TxtMonto.Text = "20";
        }

        private void Btn50_Click(object sender, EventArgs e)
        {
            TxtMonto.Text = "50";
        }

        private void Btn100_Click(object sender, EventArgs e)
        {
            TxtMonto.Text = "100";
        }

        private void Btn200_Click(object sender, EventArgs e)
        {
            TxtMonto.Text = "200";
        }

        private void Btn500_Click(object sender, EventArgs e)
        {
            TxtMonto.Text = "500";
        }

        private void Btn3000_Click(object sender, EventArgs e)
        {
            TxtMonto.Text = "3000";
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                TxtMonto.Text = NudOtroMonto.Value.ToString();
            }
        }

        private void CalcularBilletes(int cantidad)
        {
            int Cajero100 = 0;
            int Cajero50 = 0;
            int Cajero20 = 0;
            if (cuentaRetiro.Tipo.Equals("S"))
            {
                Cajero100 = Program.cajero.DineroSoles.CantidadBillete20;
                Cajero50 = Program.cajero.DineroSoles.CantidadBillete50;
                Cajero20 = Program.cajero.DineroSoles.CantidadBillete100;
            }
            else
            {
                Cajero100 = Program.cajero.DineroDolares.CantidadBillete20;
                Cajero50 = Program.cajero.DineroDolares.CantidadBillete50;
                Cajero20 = Program.cajero.DineroDolares.CantidadBillete100;
            }
            int monto = cantidad;
            C100 = 0;
            C50 = 0;
            C20 = 0;

            if (monto >= 100 && Cajero100 > 0)
            {
                C100 = ((int)monto / 100);
                monto -= (C100 * 100);

                if (monto == 10 || monto == 30)
                {
                    monto += 100;
                    C100--;
                }
            }
            if (monto >= 50 && Cajero50 > 0)
            {
                C50 = ((int)monto / 50);
                monto -= (C50 * 50);
                if (monto == 10 || monto == 30)
                {
                    monto += 50;
                    C50 -= 1;
                }
            }
            if (monto >= 20 && Cajero50 > 0)
            {
                C20 = ((int)monto / 20);
                monto -= (C20 * 20);
            }
        }

        private void NudOtroMonto_Validating(object sender, CancelEventArgs e)
        {
            if (NudOtroMonto.Value != 30 && NudOtroMonto.Value % 10 == 0)
            {
                ErrNotificador.SetError(NudOtroMonto, "");
            }
            else
            {
                ErrNotificador.SetError(NudOtroMonto, "Ingrese una cantidad que termine en 0");
                e.Cancel = true;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtMonto.Text.Length == 0)
            {
                MessageBox.Show("Seleccione o ingrese una cantidad a retirar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ValidateChildren();
            }
            else if (ValidateChildren() == true)
            {
                int montoRetirar = int.Parse(TxtMonto.Text);

                if (cuentaRetiro.Tipo == "S" && montoRetirar > Program.cajero.DineroSoles.MontoTotal)
                {
                    MessageBox.Show("El cajero no cuenta con el monto solicitado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cuentaRetiro.Tipo == "D" && montoRetirar > Program.cajero.DineroDolares.MontoTotal)
                {
                    MessageBox.Show("El cajero no cuenta con el monto solicitado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cuentaRetiro.Saldo < montoRetirar)
                {
                    MessageBox.Show("Saldo insuficiente para realizar la operación.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CalcularBilletes(montoRetirar);

                var montoCalculoBilletes = C20 * 20 + C50 * 50 + C100 * 100;

                if (montoRetirar != montoCalculoBilletes)
                {
                    MessageBox.Show("El cajero no cuenta con billetes sucificientes para el monto solicitado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cuentaRetiro.Tipo.Equals("S"))
                {
                    Program.cajero.DineroSoles.CantidadBillete20 -= C20;
                    Program.cajero.DineroSoles.CantidadBillete50 -= C50;
                    Program.cajero.DineroSoles.CantidadBillete100 -= C100;
                    Program.cajero.DineroSoles.MontoTotal -= montoRetirar;
                }
                else
                {
                    Program.cajero.DineroDolares.CantidadBillete20 -= C20;
                    Program.cajero.DineroDolares.CantidadBillete50 -= C50;
                    Program.cajero.DineroDolares.CantidadBillete100 -= C100;
                    Program.cajero.DineroDolares.MontoTotal -= montoRetirar;
                }

                var retiro = new Retiro()
                {
                    Cliente = cuentaRetiro.Cliente,
                    CuentaBancaria = cuentaRetiro,
                    Fecha = DateTime.Now,
                    Monto = montoRetirar,
                };

                foreach (var cuenta in Program.cuentasBancarias)
                {
                    if (cuenta.Equals(cuentaRetiro))
                    {
                        cuenta.Saldo -= montoRetirar;
                    }
                }

                Program.operaciones.Add(retiro);

                MessageBox.Show($"Retiro realizado con éxito. Recoja su dinero: " +
                    $"\n Billetes de 20: {C20} " +
                    $"\n Billetes de 50: {C50} " +
                    $"\n Billetes de 100: {C100}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerarVaucher();
                this.Close();
            }
        }

        public void GenerarVaucher()
        {
            var ruta = $"{Program.rutaGuardar}Retiro_{Program.sesionCliente.Dni}_{cuentaRetiro.Numero}_{DateTime.Now:ddMMyyHHmmss}.pdf";
            FileStream fs = new FileStream(@ruta, FileMode.Create);

            Document doc = new Document(PageSize.A6, 10, 10, 20, 20);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.AddTitle("Voucher retiro");
            doc.AddCreator("Cajero automatico");

            doc.Open();

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            doc.Add(new Paragraph($"CAJERO UNPRG", _standardFont) { Alignment = Element.ALIGN_RIGHT });
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("RETIRO", _standardFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph($"FECHA: {DateTime.Now}", _standardFont) { Alignment = Element.ALIGN_RIGHT });
            doc.Add(Chunk.NEWLINE);

            PdfPTable tabla = new PdfPTable(2);
            tabla.WidthPercentage = 100;

            PdfPCell cell = new PdfPCell(new Phrase(cuentaRetiro.Cliente.NombreCompleto.ToUpper(), _standardFont));
            cell.Colspan = 3;
            cell.BorderWidth = 0;
            tabla.AddCell(cell);

            cell = new PdfPCell(new Phrase($"NUMERO CUENTA: {cuentaRetiro.Numero}", _standardFont));
            cell.Colspan = 3;
            cell.BorderWidth = 0;
            tabla.AddCell(cell);

            cell = new PdfPCell(new Phrase($"CCI: {cuentaRetiro.CCI}", _standardFont));
            cell.Colspan = 3;
            cell.BorderWidth = 0;
            tabla.AddCell(cell);

            PdfPCell clItem1 = new PdfPCell(new Phrase("IMPORTE RETIRADO :", _standardFont));
            clItem1.BorderWidth = 0;
            PdfPCell clItem2 = new PdfPCell(new Phrase(DineroMostrar(TxtMonto.Text), _standardFont));
            clItem2.BorderWidth = 0;
            tabla.AddCell(clItem1);
            tabla.AddCell(clItem2);

            cell = new PdfPCell(new Phrase("---------------------------------------------", _standardFont));
            cell.Colspan = 3;
            cell.BorderWidth = 0;
            tabla.AddCell(cell);

            clItem1 = new PdfPCell(new Phrase("SALDO DISPONIBLE :", _standardFont));
            clItem1.BorderWidth = 0;
            clItem2 = new PdfPCell(new Phrase(DineroMostrar(cuentaRetiro.Saldo.ToString()), _standardFont));
            clItem2.BorderWidth = 0;
            tabla.AddCell(clItem1);
            tabla.AddCell(clItem2);

            doc.Add(tabla);

            doc.Add(Chunk.NEWLINE);

            PdfPTable tabla2 = new PdfPTable(2);
            tabla2.WidthPercentage = 100;

            cell = new PdfPCell(new Phrase("BILLETES ENTREGADOS", _standardFont));
            cell.Colspan = 3;
            cell.BorderWidth = 0;
            tabla2.AddCell(cell);

            clItem1 = new PdfPCell(new Phrase("BILLETES DE 20  :", _standardFont));
            clItem1.BorderWidth = 0;
            clItem2 = new PdfPCell(new Phrase(C20.ToString(), _standardFont));
            clItem2.BorderWidth = 0;
            tabla2.AddCell(clItem1);
            tabla2.AddCell(clItem2);

            clItem1 = new PdfPCell(new Phrase("BILLETES DE 50  :", _standardFont));
            clItem1.BorderWidth = 0;
            clItem2 = new PdfPCell(new Phrase(C50.ToString(), _standardFont));
            clItem2.BorderWidth = 0;
            tabla2.AddCell(clItem1);
            tabla2.AddCell(clItem2);

            clItem1 = new PdfPCell(new Phrase("BILLETES DE 100 :", _standardFont));
            clItem1.BorderWidth = 0;
            clItem2 = new PdfPCell(new Phrase(C100.ToString(), _standardFont));
            clItem2.BorderWidth = 0;
            tabla2.AddCell(clItem1);
            tabla2.AddCell(clItem2);

            doc.Add(tabla2);


            doc.Close();
            writer.Close();
            System.Diagnostics.Process.Start(ruta);

        }

        private string DineroMostrar(string monto)
        {
            string montoMostrar = "";
            if (cuentaRetiro.Tipo.Equals("S"))
            {
                var cant = 20 - monto.Length;
                string asterisco = "";
                for (int i = 0; i < cant; i++)
                {
                    asterisco = $"{asterisco}*";
                }
                montoMostrar = $"S/{asterisco}{monto}";
            }
            else
            {
                var cant = 21 - monto.Length;
                string asterisco = "";
                for (int i = 0; i < cant; i++)
                {
                    asterisco = $"{asterisco}*";
                }
                montoMostrar = $"${asterisco}{monto}";
            }
            return montoMostrar;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRetiro_Load_1(object sender, EventArgs e)
        {
            var encontrados = BuscarCuentas();
            if (encontrados.Count > 0)
            {
                CboCuentas.DisplayMember = "Numero";
                CboCuentas.DataSource = encontrados;
            }
            CboCuentas.SelectedIndex = -1;
            TxtTipoMonedaMisCuentas.Text = "";
        }

        private List<CuentaBancaria> BuscarCuentas()
        {
            var encontrados = new List<CuentaBancaria>();

            encontrados = (from cuenta in Program.cuentasBancarias
                           where cuenta.Cliente == Program.sesionCliente
                           select cuenta).ToList();
            return encontrados;
        }

        private void CboCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCuentas.SelectedIndex > -1)
            {
                var cuenta = (CuentaBancaria)CboCuentas.SelectedItem;
                cuentaRetiro = cuenta;
                TxtTipoMonedaMisCuentas.Text = cuenta.NombreTipoMoneda;
                LblMontoRetirar.Text = cuentaRetiro.Tipo.Equals("S") ? "Monto total S/" : "Monto total $";
                ErrNotificador.SetError(CboCuentas, "");
            }
        }

        private void CboCuentas_Validating(object sender, CancelEventArgs e)
        {
            if (CboCuentas.SelectedIndex > -1)
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
}
