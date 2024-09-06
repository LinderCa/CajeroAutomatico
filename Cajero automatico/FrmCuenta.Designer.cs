namespace Cajero_automatico
{
    partial class FrmCuentaBancaria
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
            this.components = new System.ComponentModel.Container();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GbEntidad = new System.Windows.Forms.GroupBox();
            this.NudSaldo = new System.Windows.Forms.NumericUpDown();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.CboTipoMoneda = new System.Windows.Forms.ComboBox();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtCCI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCerrar = new System.Windows.Forms.Button();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.CdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdCCI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdTipoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.GbEntidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // GbListado
            // 
            this.GbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Location = new System.Drawing.Point(363, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(609, 469);
            this.GbListado.TabIndex = 5;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdCliente,
            this.CdNumero,
            this.CdCCI,
            this.CdTipoMoneda,
            this.CdVigente});
            this.DgvListado.Location = new System.Drawing.Point(17, 50);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(577, 361);
            this.DgvListado.TabIndex = 1;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Location = new System.Drawing.Point(113, 428);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "&Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Location = new System.Drawing.Point(519, 21);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 0;
            this.BtnListar.Text = "&Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.Location = new System.Drawing.Point(17, 428);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // GbEntidad
            // 
            this.GbEntidad.Controls.Add(this.NudSaldo);
            this.GbEntidad.Controls.Add(this.CboCliente);
            this.GbEntidad.Controls.Add(this.CboTipoMoneda);
            this.GbEntidad.Controls.Add(this.ChkVigente);
            this.GbEntidad.Controls.Add(this.label6);
            this.GbEntidad.Controls.Add(this.BtnCancelar);
            this.GbEntidad.Controls.Add(this.BtnAceptar);
            this.GbEntidad.Controls.Add(this.TxtCCI);
            this.GbEntidad.Controls.Add(this.label3);
            this.GbEntidad.Controls.Add(this.TxtNumero);
            this.GbEntidad.Controls.Add(this.label4);
            this.GbEntidad.Controls.Add(this.label2);
            this.GbEntidad.Controls.Add(this.label1);
            this.GbEntidad.Enabled = false;
            this.GbEntidad.Location = new System.Drawing.Point(12, 12);
            this.GbEntidad.Name = "GbEntidad";
            this.GbEntidad.Size = new System.Drawing.Size(345, 246);
            this.GbEntidad.TabIndex = 4;
            this.GbEntidad.TabStop = false;
            this.GbEntidad.Text = "Cuenta bancaria";
            // 
            // NudSaldo
            // 
            this.NudSaldo.DecimalPlaces = 2;
            this.NudSaldo.Location = new System.Drawing.Point(92, 134);
            this.NudSaldo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NudSaldo.Name = "NudSaldo";
            this.NudSaldo.Size = new System.Drawing.Size(218, 20);
            this.NudSaldo.TabIndex = 14;
            // 
            // CboCliente
            // 
            this.CboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Items.AddRange(new object[] {
            ""});
            this.CboCliente.Location = new System.Drawing.Point(92, 27);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(218, 21);
            this.CboCliente.TabIndex = 11;
            this.CboCliente.Validating += new System.ComponentModel.CancelEventHandler(this.CboTipoMoneda_Validating);
            // 
            // CboTipoMoneda
            // 
            this.CboTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoMoneda.FormattingEnabled = true;
            this.CboTipoMoneda.Items.AddRange(new object[] {
            "Soles ",
            "Dólares"});
            this.CboTipoMoneda.Location = new System.Drawing.Point(92, 106);
            this.CboTipoMoneda.Name = "CboTipoMoneda";
            this.CboTipoMoneda.Size = new System.Drawing.Size(218, 21);
            this.CboTipoMoneda.TabIndex = 13;
            this.CboTipoMoneda.Validating += new System.ComponentModel.CancelEventHandler(this.CboTipoMoneda_Validating);
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(92, 170);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 10;
            this.ChkVigente.Text = "Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo moneda";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(235, 205);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(139, 205);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtCCI
            // 
            this.TxtCCI.Location = new System.Drawing.Point(92, 80);
            this.TxtCCI.Name = "TxtCCI";
            this.TxtCCI.Size = new System.Drawing.Size(218, 20);
            this.TxtCCI.TabIndex = 1;
            this.TxtCCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            this.TxtCCI.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumero_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Saldo";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(92, 54);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(218, 20);
            this.TxtNumero.TabIndex = 1;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            this.TxtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumero_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "CCI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // TxtCerrar
            // 
            this.TxtCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCerrar.Location = new System.Drawing.Point(897, 490);
            this.TxtCerrar.Name = "TxtCerrar";
            this.TxtCerrar.Size = new System.Drawing.Size(75, 23);
            this.TxtCerrar.TabIndex = 3;
            this.TxtCerrar.Text = "C&errar";
            this.TxtCerrar.UseVisualStyleBackColor = true;
            this.TxtCerrar.Click += new System.EventHandler(this.TxtCerrar_Click);
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // CdCliente
            // 
            this.CdCliente.DataPropertyName = "NombreCliente";
            this.CdCliente.HeaderText = "Cliente";
            this.CdCliente.Name = "CdCliente";
            this.CdCliente.ReadOnly = true;
            // 
            // CdNumero
            // 
            this.CdNumero.DataPropertyName = "Numero";
            this.CdNumero.HeaderText = "Numero";
            this.CdNumero.Name = "CdNumero";
            this.CdNumero.ReadOnly = true;
            // 
            // CdCCI
            // 
            this.CdCCI.DataPropertyName = "CCI";
            this.CdCCI.HeaderText = "CCI";
            this.CdCCI.Name = "CdCCI";
            this.CdCCI.ReadOnly = true;
            // 
            // CdTipoMoneda
            // 
            this.CdTipoMoneda.DataPropertyName = "NombreTipoMoneda";
            this.CdTipoMoneda.HeaderText = "Tipo de moneda";
            this.CdTipoMoneda.Name = "CdTipoMoneda";
            this.CdTipoMoneda.ReadOnly = true;
            // 
            // CdVigente
            // 
            this.CdVigente.DataPropertyName = "Vigente";
            this.CdVigente.HeaderText = "Vigente";
            this.CdVigente.Name = "CdVigente";
            this.CdVigente.ReadOnly = true;
            // 
            // FrmCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(984, 525);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.TxtCerrar);
            this.Controls.Add(this.GbEntidad);
            this.Name = "FrmCuentaBancaria";
            this.Text = "Gestión cuenta bancaria";
            this.Load += new System.EventHandler(this.FrmCuenta_Load);
            this.GbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.GbEntidad.ResumeLayout(false);
            this.GbEntidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox GbEntidad;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.ComboBox CboTipoMoneda;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtCCI;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TxtCerrar;
        private System.Windows.Forms.NumericUpDown NudSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCCI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTipoMoneda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CdVigente;
    }
}