namespace Cajero_automatico
{
    partial class FrmListaDepositosSinCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnExportarExcel = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.LblFin = new System.Windows.Forms.Label();
            this.LblInicio = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.CdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdTipoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardarArchivoDialogo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(574, 415);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 26;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Location = new System.Drawing.Point(547, 13);
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.Size = new System.Drawing.Size(102, 23);
            this.BtnExportarExcel.TabIndex = 24;
            this.BtnExportarExcel.Text = "Exportar a excel";
            this.BtnExportarExcel.UseVisualStyleBackColor = true;
            this.BtnExportarExcel.Click += new System.EventHandler(this.BtnExportarExcel_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(466, 13);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 25;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // DtpFin
            // 
            this.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFin.Location = new System.Drawing.Point(211, 16);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(96, 20);
            this.DtpFin.TabIndex = 22;
            // 
            // DtpInicio
            // 
            this.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpInicio.Location = new System.Drawing.Point(50, 16);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(107, 20);
            this.DtpInicio.TabIndex = 23;
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Location = new System.Drawing.Point(184, 19);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(21, 13);
            this.LblFin.TabIndex = 20;
            this.LblFin.Text = "Fin";
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Location = new System.Drawing.Point(12, 19);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(32, 13);
            this.LblInicio.TabIndex = 21;
            this.LblInicio.Text = "Inicio";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdFecha,
            this.CdTipoOperacion,
            this.CdTipoMoneda,
            this.CdMonto});
            this.DgvListado.Location = new System.Drawing.Point(12, 52);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(637, 357);
            this.DgvListado.TabIndex = 19;
            // 
            // CdFecha
            // 
            this.CdFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle9.Format = "G";
            dataGridViewCellStyle9.NullValue = null;
            this.CdFecha.DefaultCellStyle = dataGridViewCellStyle9;
            this.CdFecha.HeaderText = "Fecha";
            this.CdFecha.Name = "CdFecha";
            this.CdFecha.ReadOnly = true;
            // 
            // CdTipoOperacion
            // 
            this.CdTipoOperacion.DataPropertyName = "Tipo";
            this.CdTipoOperacion.HeaderText = "Tipo de operación";
            this.CdTipoOperacion.Name = "CdTipoOperacion";
            this.CdTipoOperacion.ReadOnly = true;
            // 
            // CdTipoMoneda
            // 
            this.CdTipoMoneda.DataPropertyName = "Moneda";
            this.CdTipoMoneda.HeaderText = "Tipo de moneda";
            this.CdTipoMoneda.Name = "CdTipoMoneda";
            this.CdTipoMoneda.ReadOnly = true;
            // 
            // CdMonto
            // 
            this.CdMonto.DataPropertyName = "Monto";
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.CdMonto.DefaultCellStyle = dataGridViewCellStyle10;
            this.CdMonto.HeaderText = "Monto ";
            this.CdMonto.Name = "CdMonto";
            this.CdMonto.ReadOnly = true;
            // 
            // FrmListaDepositosSinCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnExportarExcel);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.DtpFin);
            this.Controls.Add(this.DtpInicio);
            this.Controls.Add(this.LblFin);
            this.Controls.Add(this.LblInicio);
            this.Controls.Add(this.DgvListado);
            this.Name = "FrmListaDepositosSinCuenta";
            this.Text = "Lista depositos sin cuenta";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnExportarExcel;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.DateTimePicker DtpInicio;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTipoOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTipoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdMonto;
        private System.Windows.Forms.SaveFileDialog GuardarArchivoDialogo;
    }
}