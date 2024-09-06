namespace Cajero_automatico
{
    partial class FrmDepositoConCuenta
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.NudBillete100 = new System.Windows.Forms.NumericUpDown();
            this.NudBillete50 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NudMontoBillete100 = new System.Windows.Forms.NumericUpDown();
            this.NudMontoBillete20 = new System.Windows.Forms.NumericUpDown();
            this.NudMontoBillete50 = new System.Windows.Forms.NumericUpDown();
            this.NudBillete20 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblMontoTotal = new System.Windows.Forms.Label();
            this.GbDestinatario = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtTipoMoneda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.ChkUnaDeMisCuentas = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboCuentas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTipoMonedaMisCuentas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudBillete100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBillete50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMontoBillete100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMontoBillete20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMontoBillete50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBillete20)).BeginInit();
            this.GbDestinatario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(330, 399);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 21;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(234, 399);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 20;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtMontoTotal);
            this.groupBox2.Controls.Add(this.NudBillete100);
            this.groupBox2.Controls.Add(this.NudBillete50);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.NudMontoBillete100);
            this.groupBox2.Controls.Add(this.NudMontoBillete20);
            this.groupBox2.Controls.Add(this.NudMontoBillete50);
            this.groupBox2.Controls.Add(this.NudBillete20);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.LblMontoTotal);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 165);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del depósito";
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.Enabled = false;
            this.TxtMontoTotal.Location = new System.Drawing.Point(203, 127);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.Size = new System.Drawing.Size(167, 20);
            this.TxtMontoTotal.TabIndex = 7;
            this.TxtMontoTotal.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMontoTotal_Validating);
            // 
            // NudBillete100
            // 
            this.NudBillete100.Location = new System.Drawing.Point(90, 91);
            this.NudBillete100.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudBillete100.Name = "NudBillete100";
            this.NudBillete100.Size = new System.Drawing.Size(107, 20);
            this.NudBillete100.TabIndex = 14;
            this.NudBillete100.ValueChanged += new System.EventHandler(this.NudBillete100_ValueChanged);
            this.NudBillete100.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudBillete100_KeyPress);
            // 
            // NudBillete50
            // 
            this.NudBillete50.Location = new System.Drawing.Point(90, 65);
            this.NudBillete50.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudBillete50.Name = "NudBillete50";
            this.NudBillete50.Size = new System.Drawing.Size(107, 20);
            this.NudBillete50.TabIndex = 15;
            this.NudBillete50.ValueChanged += new System.EventHandler(this.NudBillete50_ValueChanged);
            this.NudBillete50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudBillete50_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Monto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Monto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Billetes de 100";
            // 
            // NudMontoBillete100
            // 
            this.NudMontoBillete100.Enabled = false;
            this.NudMontoBillete100.Location = new System.Drawing.Point(263, 91);
            this.NudMontoBillete100.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NudMontoBillete100.Name = "NudMontoBillete100";
            this.NudMontoBillete100.Size = new System.Drawing.Size(107, 20);
            this.NudMontoBillete100.TabIndex = 16;
            // 
            // NudMontoBillete20
            // 
            this.NudMontoBillete20.Enabled = false;
            this.NudMontoBillete20.Location = new System.Drawing.Point(263, 41);
            this.NudMontoBillete20.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NudMontoBillete20.Name = "NudMontoBillete20";
            this.NudMontoBillete20.Size = new System.Drawing.Size(107, 20);
            this.NudMontoBillete20.TabIndex = 17;
            // 
            // NudMontoBillete50
            // 
            this.NudMontoBillete50.Enabled = false;
            this.NudMontoBillete50.Location = new System.Drawing.Point(263, 65);
            this.NudMontoBillete50.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NudMontoBillete50.Name = "NudMontoBillete50";
            this.NudMontoBillete50.Size = new System.Drawing.Size(107, 20);
            this.NudMontoBillete50.TabIndex = 18;
            // 
            // NudBillete20
            // 
            this.NudBillete20.Location = new System.Drawing.Point(90, 39);
            this.NudBillete20.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudBillete20.Name = "NudBillete20";
            this.NudBillete20.Size = new System.Drawing.Size(107, 20);
            this.NudBillete20.TabIndex = 19;
            this.NudBillete20.ValueChanged += new System.EventHandler(this.NudBillete20_ValueChanged);
            this.NudBillete20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudBillete20_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Billetes de 50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Billetes de 20";
            // 
            // LblMontoTotal
            // 
            this.LblMontoTotal.AutoSize = true;
            this.LblMontoTotal.Location = new System.Drawing.Point(126, 130);
            this.LblMontoTotal.Name = "LblMontoTotal";
            this.LblMontoTotal.Size = new System.Drawing.Size(60, 13);
            this.LblMontoTotal.TabIndex = 6;
            this.LblMontoTotal.Text = "Monto total";
            // 
            // GbDestinatario
            // 
            this.GbDestinatario.Controls.Add(this.label12);
            this.GbDestinatario.Controls.Add(this.CboCuentas);
            this.GbDestinatario.Controls.Add(this.ChkUnaDeMisCuentas);
            this.GbDestinatario.Controls.Add(this.BtnBuscar);
            this.GbDestinatario.Controls.Add(this.TxtTipoMonedaMisCuentas);
            this.GbDestinatario.Controls.Add(this.label4);
            this.GbDestinatario.Controls.Add(this.TxtTipoMoneda);
            this.GbDestinatario.Controls.Add(this.label5);
            this.GbDestinatario.Controls.Add(this.TxtNombre);
            this.GbDestinatario.Controls.Add(this.label1);
            this.GbDestinatario.Controls.Add(this.TxtNumeroCuenta);
            this.GbDestinatario.Controls.Add(this.label3);
            this.GbDestinatario.Controls.Add(this.label2);
            this.GbDestinatario.Location = new System.Drawing.Point(12, 12);
            this.GbDestinatario.Name = "GbDestinatario";
            this.GbDestinatario.Size = new System.Drawing.Size(393, 210);
            this.GbDestinatario.TabIndex = 18;
            this.GbDestinatario.TabStop = false;
            this.GbDestinatario.Text = "Datos del destinatario";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Enabled = false;
            this.BtnBuscar.Location = new System.Drawing.Point(295, 127);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtTipoMoneda
            // 
            this.TxtTipoMoneda.Enabled = false;
            this.TxtTipoMoneda.Location = new System.Drawing.Point(113, 181);
            this.TxtTipoMoneda.Name = "TxtTipoMoneda";
            this.TxtTipoMoneda.Size = new System.Drawing.Size(257, 20);
            this.TxtTipoMoneda.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo moneda";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(113, 155);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(257, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // TxtNumeroCuenta
            // 
            this.TxtNumeroCuenta.Enabled = false;
            this.TxtNumeroCuenta.Location = new System.Drawing.Point(113, 129);
            this.TxtNumeroCuenta.Name = "TxtNumeroCuenta";
            this.TxtNumeroCuenta.Size = new System.Drawing.Size(165, 20);
            this.TxtNumeroCuenta.TabIndex = 1;
            this.TxtNumeroCuenta.Validating += new System.ComponentModel.CancelEventHandler(this.TxtControl_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero de cuenta";
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // ChkUnaDeMisCuentas
            // 
            this.ChkUnaDeMisCuentas.AutoSize = true;
            this.ChkUnaDeMisCuentas.Location = new System.Drawing.Point(10, 28);
            this.ChkUnaDeMisCuentas.Name = "ChkUnaDeMisCuentas";
            this.ChkUnaDeMisCuentas.Size = new System.Drawing.Size(120, 17);
            this.ChkUnaDeMisCuentas.TabIndex = 3;
            this.ChkUnaDeMisCuentas.Text = "Una de mis cuentas";
            this.ChkUnaDeMisCuentas.UseVisualStyleBackColor = true;
            this.ChkUnaDeMisCuentas.CheckedChanged += new System.EventHandler(this.ChkUnaDeMisCuentas_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cuenta";
            // 
            // CboCuentas
            // 
            this.CboCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCuentas.FormattingEnabled = true;
            this.CboCuentas.Location = new System.Drawing.Point(113, 54);
            this.CboCuentas.Name = "CboCuentas";
            this.CboCuentas.Size = new System.Drawing.Size(257, 21);
            this.CboCuentas.TabIndex = 4;
            this.CboCuentas.SelectedIndexChanged += new System.EventHandler(this.CboCuentas_SelectedIndexChanged);
            this.CboCuentas.Validating += new System.ComponentModel.CancelEventHandler(this.CboCuentas_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo moneda";
            // 
            // TxtTipoMonedaMisCuentas
            // 
            this.TxtTipoMonedaMisCuentas.Enabled = false;
            this.TxtTipoMonedaMisCuentas.Location = new System.Drawing.Point(113, 81);
            this.TxtTipoMonedaMisCuentas.Name = "TxtTipoMonedaMisCuentas";
            this.TxtTipoMonedaMisCuentas.Size = new System.Drawing.Size(257, 20);
            this.TxtTipoMonedaMisCuentas.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(367, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "____________________________________________________________";
            // 
            // FrmDepositoConCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(417, 431);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbDestinatario);
            this.Name = "FrmDepositoConCuenta";
            this.Text = "Depósito";
            this.Load += new System.EventHandler(this.FrmDepositoConCuenta_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudBillete100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBillete50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMontoBillete100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMontoBillete20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMontoBillete50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudBillete20)).EndInit();
            this.GbDestinatario.ResumeLayout(false);
            this.GbDestinatario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtMontoTotal;
        private System.Windows.Forms.NumericUpDown NudBillete100;
        private System.Windows.Forms.NumericUpDown NudBillete50;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NudMontoBillete100;
        private System.Windows.Forms.NumericUpDown NudMontoBillete20;
        private System.Windows.Forms.NumericUpDown NudMontoBillete50;
        private System.Windows.Forms.NumericUpDown NudBillete20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblMontoTotal;
        private System.Windows.Forms.GroupBox GbDestinatario;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtTipoMoneda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumeroCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.CheckBox ChkUnaDeMisCuentas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CboCuentas;
        private System.Windows.Forms.TextBox TxtTipoMonedaMisCuentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}