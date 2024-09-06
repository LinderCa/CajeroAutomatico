using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Cajero_automatico
{
    public partial class FrmListaDepositoConCuenta : Form
    {
        public FrmListaDepositoConCuenta()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            List<OperacionRealizada> encontradas = ListarOperacionesRealizadas();

            this.DgvListado.DataSource = null;
            if (encontradas.Count > 0)
            {
                this.DgvListado.AutoGenerateColumns = false;
                this.DgvListado.DataSource = encontradas;
            }
            else
            {
                MessageBox.Show("No se realizaron operaciones en este rango de fechas", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<OperacionRealizada> ListarOperacionesRealizadas()
        {
            var encontradas = new List<OperacionRealizada>();

            var operaciones = (from operacion in Program.operaciones
                               where operacion.Fecha.Date >= DtpInicio.Value.Date &&
                                     operacion.Fecha.Date <= DtpFin.Value.Date
                               select operacion).ToList();

            foreach (var operacion in operaciones)
            {
                if (operacion is DepositoConCuenta)
                {
                    var depositoConCuenta = (DepositoConCuenta)operacion;
                    encontradas.Add(new OperacionRealizada
                    {
                        Fecha = depositoConCuenta.Fecha,
                        Moneda = depositoConCuenta.CuentaDestino.NombreTipoMoneda,
                        Monto = depositoConCuenta.Monto,
                        Tipo = "Depósito con cuenta"
                    });
                }
            }

            return encontradas;
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (DgvListado.RowCount == 0)
            {
                MessageBox.Show("Primero haga un listado en un rango de fechas", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.BtnListar.Focus();
            }
            else
            {
                GuardarArchivoDialogo.Filter = "Libro de Excel|*.xlsx";
                GuardarArchivoDialogo.FileName = $"{this.Text}{DateTime.Now:ddMMyyHHmmss}";
                GuardarArchivoDialogo.DefaultExt = ".xlsx";

                if (GuardarArchivoDialogo.ShowDialog() == DialogResult.OK)
                {
                    ExportarAExcel();
                }
            }
        }

        private void ExportarAExcel()
        {
            DataTable tablaDatos = CrearTablaDatos();
            SLDocument documento = CrearDocumentoExcel(tablaDatos);
            documento.SaveAs(GuardarArchivoDialogo.FileName);
        }

        private DataTable CrearTablaDatos()
        {
            DataTable tablaDatos = new DataTable();
            tablaDatos.Columns.Add("Fecha", typeof(DateTime));
            tablaDatos.Columns.Add("Tipo de operacion", typeof(string));
            tablaDatos.Columns.Add("Tipo de moneda", typeof(string));
            tablaDatos.Columns.Add("Monto", typeof(double));

            foreach (DataGridViewRow row in DgvListado.Rows)
            {
                tablaDatos.Rows.Add(
                    DateTime.Parse(row.Cells["CdFecha"].Value.ToString()),
                    row.Cells["CdTipoOperacion"].Value.ToString(),
                    row.Cells["CdTipoMoneda"].Value.ToString(),
                    double.Parse(row.Cells["CdMonto"].Value.ToString()));
            }

            return tablaDatos;
        }

        private SLDocument CrearDocumentoExcel(DataTable tablaDatos)
        {
            SLDocument documento = new SLDocument();

            documento.SetCellValue("B2", "CAJERO AUTOMÁTICO");
            documento.SetCellValue("B3", $"LISTA DE DEPOSITOS CON CUENTA DEL {DtpInicio.Value.Date:dd/MM/yyyy} AL {DtpFin.Value.Date:dd/MM/yyyy}");
            SLStyle estilos = documento.CreateStyle();
            estilos.Font.Bold = true;
            estilos.Alignment.Vertical = VerticalAlignmentValues.Center;
            estilos.Alignment.Horizontal = HorizontalAlignmentValues.Center;

            documento.MergeWorksheetCells("B2", "E2");
            documento.MergeWorksheetCells("B3", "E3");
            documento.SetCellStyle("B2", "E3", estilos);

            int indexFilaInicio = 5;
            int indexColumnaInicio = 2;

            documento.ImportDataTable(indexFilaInicio, indexColumnaInicio, tablaDatos, true);

            SLStyle style = documento.CreateStyle();
            style.FormatCode = "dd/mm/yyyy";
            documento.SetColumnStyle(2, style);

            style.FormatCode = "#,##0.00";
            documento.SetColumnStyle(5, style);

            int indexFilaFin = indexFilaInicio + tablaDatos.Rows.Count;
            int indexColumnaFin = indexColumnaInicio + tablaDatos.Columns.Count - 1;

            documento.AutoFitColumn(indexColumnaInicio, indexColumnaFin);
            documento.AutoFitRow(2, indexFilaFin);

            SLTable table = documento.CreateTable(indexFilaInicio, indexColumnaInicio, indexFilaFin, indexColumnaFin);
            table.SetTableStyle(SLTableStyleTypeValues.Light11);
            table.HasAutoFilter = false;
            documento.InsertTable(table);
            documento.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Listado");

            return documento;
        }
    }
}
