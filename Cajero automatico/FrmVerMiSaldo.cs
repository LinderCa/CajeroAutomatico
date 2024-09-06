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
    public partial class FrmVerMiSaldo : Form
    {
        private CuentaBancaria cuentaVer = new CuentaBancaria();
        public FrmVerMiSaldo()
        {
            InitializeComponent();
        }

        private void CboCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCuentas.SelectedIndex > -1)
            {
                var cuenta = (CuentaBancaria)CboCuentas.SelectedItem;
                cuentaVer = cuenta;
                TxtTipoMonedaMisCuentas.Text = cuenta.NombreTipoMoneda;
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVerMiSaldo_Load(object sender, EventArgs e)
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

        private void BtnEnPantalla_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                MessageBox.Show($" NOMBRE: {Program.sesionCliente.NombreCompleto}" +
                    $"\n NUMERO DE CUENTA: {cuentaVer.Numero} " +
                    $"\n CCI: {cuentaVer.CCI} " +
                    $"\n SALDO DISPONIBLE: {cuentaVer.Saldo}", this.Text, MessageBoxButtons.OK);
            }
        }

        private void BtnEnVoucher_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var ruta = $"{Program.rutaGuardar}VerMiSaldo{Program.sesionCliente.Dni}_{cuentaVer.Numero}_{DateTime.Now:ddMMyyHHmmss}.pdf";
                FileStream fs = new FileStream(@ruta, FileMode.Create);

                Document doc = new Document(PageSize.A6, 10, 10, 50, 20);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                doc.AddTitle("Voucher ver mi saldo");
                doc.AddCreator("Cajero automatico");

                doc.Open();

                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                doc.Add(new Paragraph($"CAJERO UNPRG", _standardFont) { Alignment = Element.ALIGN_RIGHT });
                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph("MI SALDO", _standardFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph($"FECHA: {DateTime.Now}", _standardFont) { Alignment = Element.ALIGN_RIGHT });
                doc.Add(Chunk.NEWLINE);

                PdfPTable tabla = new PdfPTable(2);
                tabla.WidthPercentage = 100;

                PdfPCell cell = new PdfPCell(new Phrase($"NOMBRE: {cuentaVer.Cliente.NombreCompleto.ToUpper()}", _standardFont));
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                tabla.AddCell(cell);

                cell = new PdfPCell(new Phrase($"NUMERO CUENTA: {cuentaVer.Numero}", _standardFont));
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                tabla.AddCell(cell);

                cell = new PdfPCell(new Phrase($"CCI: {cuentaVer.CCI}", _standardFont));
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                tabla.AddCell(cell);

                cell = new PdfPCell(new Phrase("---------------------------------------------", _standardFont));
                cell.Colspan = 3;
                cell.BorderWidth = 0;
                tabla.AddCell(cell);

                PdfPCell clItem1 = new PdfPCell(new Phrase("SALDO DISPONIBLE :", _standardFont));
                clItem1.BorderWidth = 0;
                PdfPCell clItem2 = new PdfPCell(new Phrase(DineroMostrar(cuentaVer.Saldo.ToString()), _standardFont));
                clItem2.BorderWidth = 0;
                tabla.AddCell(clItem1);
                tabla.AddCell(clItem2);

                doc.Add(tabla);

                doc.Add(Chunk.NEWLINE);

                doc.Close();
                writer.Close();
                System.Diagnostics.Process.Start(ruta);
            }
        }

        private string DineroMostrar(string monto)
        {
            string montoMostrar = "";
            if (cuentaVer.Tipo.Equals("S"))
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
    }
}
