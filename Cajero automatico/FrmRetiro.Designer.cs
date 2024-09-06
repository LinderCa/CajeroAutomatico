namespace Cajero_automatico
{
    partial class FrmRetiro
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
            this.GbEntidad = new System.Windows.Forms.GroupBox();
            this.NudOtroMonto = new System.Windows.Forms.NumericUpDown();
            this.LblMaximo = new System.Windows.Forms.Label();
            this.LblOtroMonto = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnOtroMonto = new System.Windows.Forms.Button();
            this.Btn3000 = new System.Windows.Forms.Button();
            this.Btn500 = new System.Windows.Forms.Button();
            this.Btn200 = new System.Windows.Forms.Button();
            this.Btn100 = new System.Windows.Forms.Button();
            this.Btn50 = new System.Windows.Forms.Button();
            this.Btn20 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.LblMontoRetirar = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbDestinatario = new System.Windows.Forms.GroupBox();
            this.CboCuentas = new System.Windows.Forms.ComboBox();
            this.TxtTipoMonedaMisCuentas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GbEntidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudOtroMonto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.GbDestinatario.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbEntidad
            // 
            this.GbEntidad.Controls.Add(this.NudOtroMonto);
            this.GbEntidad.Controls.Add(this.LblMaximo);
            this.GbEntidad.Controls.Add(this.LblOtroMonto);
            this.GbEntidad.Controls.Add(this.BtnConfirmar);
            this.GbEntidad.Controls.Add(this.BtnOtroMonto);
            this.GbEntidad.Controls.Add(this.Btn3000);
            this.GbEntidad.Controls.Add(this.Btn500);
            this.GbEntidad.Controls.Add(this.Btn200);
            this.GbEntidad.Controls.Add(this.Btn100);
            this.GbEntidad.Controls.Add(this.Btn50);
            this.GbEntidad.Controls.Add(this.Btn20);
            this.GbEntidad.Location = new System.Drawing.Point(12, 101);
            this.GbEntidad.Name = "GbEntidad";
            this.GbEntidad.Size = new System.Drawing.Size(393, 154);
            this.GbEntidad.TabIndex = 6;
            this.GbEntidad.TabStop = false;
            this.GbEntidad.Text = "Monto a retirar";
            // 
            // NudOtroMonto
            // 
            this.NudOtroMonto.Enabled = false;
            this.NudOtroMonto.Location = new System.Drawing.Point(100, 102);
            this.NudOtroMonto.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NudOtroMonto.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudOtroMonto.Name = "NudOtroMonto";
            this.NudOtroMonto.Size = new System.Drawing.Size(120, 20);
            this.NudOtroMonto.TabIndex = 2;
            this.NudOtroMonto.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudOtroMonto.Validating += new System.ComponentModel.CancelEventHandler(this.NudOtroMonto_Validating);
            // 
            // LblMaximo
            // 
            this.LblMaximo.AutoSize = true;
            this.LblMaximo.Enabled = false;
            this.LblMaximo.Location = new System.Drawing.Point(96, 128);
            this.LblMaximo.Name = "LblMaximo";
            this.LblMaximo.Size = new System.Drawing.Size(70, 13);
            this.LblMaximo.TabIndex = 1;
            this.LblMaximo.Text = "Máximo 3000";
            // 
            // LblOtroMonto
            // 
            this.LblOtroMonto.AutoSize = true;
            this.LblOtroMonto.Enabled = false;
            this.LblOtroMonto.Location = new System.Drawing.Point(35, 104);
            this.LblOtroMonto.Name = "LblOtroMonto";
            this.LblOtroMonto.Size = new System.Drawing.Size(59, 13);
            this.LblOtroMonto.TabIndex = 1;
            this.LblOtroMonto.Text = "Otro monto";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Enabled = false;
            this.BtnConfirmar.Location = new System.Drawing.Point(269, 99);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmar.TabIndex = 0;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnOtroMonto
            // 
            this.BtnOtroMonto.Location = new System.Drawing.Point(244, 58);
            this.BtnOtroMonto.Name = "BtnOtroMonto";
            this.BtnOtroMonto.Size = new System.Drawing.Size(75, 23);
            this.BtnOtroMonto.TabIndex = 0;
            this.BtnOtroMonto.Text = "Otro monto";
            this.BtnOtroMonto.UseVisualStyleBackColor = true;
            this.BtnOtroMonto.Click += new System.EventHandler(this.BtnOtroMonto_Click);
            // 
            // Btn3000
            // 
            this.Btn3000.Location = new System.Drawing.Point(163, 58);
            this.Btn3000.Name = "Btn3000";
            this.Btn3000.Size = new System.Drawing.Size(75, 23);
            this.Btn3000.TabIndex = 0;
            this.Btn3000.Text = "3000";
            this.Btn3000.UseVisualStyleBackColor = true;
            this.Btn3000.Click += new System.EventHandler(this.Btn3000_Click);
            // 
            // Btn500
            // 
            this.Btn500.Location = new System.Drawing.Point(82, 58);
            this.Btn500.Name = "Btn500";
            this.Btn500.Size = new System.Drawing.Size(75, 23);
            this.Btn500.TabIndex = 0;
            this.Btn500.Text = "500";
            this.Btn500.UseVisualStyleBackColor = true;
            this.Btn500.Click += new System.EventHandler(this.Btn500_Click);
            // 
            // Btn200
            // 
            this.Btn200.Location = new System.Drawing.Point(279, 29);
            this.Btn200.Name = "Btn200";
            this.Btn200.Size = new System.Drawing.Size(75, 23);
            this.Btn200.TabIndex = 0;
            this.Btn200.Text = "200";
            this.Btn200.UseVisualStyleBackColor = true;
            this.Btn200.Click += new System.EventHandler(this.Btn200_Click);
            // 
            // Btn100
            // 
            this.Btn100.Location = new System.Drawing.Point(198, 29);
            this.Btn100.Name = "Btn100";
            this.Btn100.Size = new System.Drawing.Size(75, 23);
            this.Btn100.TabIndex = 0;
            this.Btn100.Text = "100";
            this.Btn100.UseVisualStyleBackColor = true;
            this.Btn100.Click += new System.EventHandler(this.Btn100_Click);
            // 
            // Btn50
            // 
            this.Btn50.Location = new System.Drawing.Point(117, 29);
            this.Btn50.Name = "Btn50";
            this.Btn50.Size = new System.Drawing.Size(75, 23);
            this.Btn50.TabIndex = 0;
            this.Btn50.Text = "50";
            this.Btn50.UseVisualStyleBackColor = true;
            this.Btn50.Click += new System.EventHandler(this.Btn50_Click);
            // 
            // Btn20
            // 
            this.Btn20.Location = new System.Drawing.Point(36, 29);
            this.Btn20.Name = "Btn20";
            this.Btn20.Size = new System.Drawing.Size(75, 23);
            this.Btn20.TabIndex = 0;
            this.Btn20.Text = "20";
            this.Btn20.UseVisualStyleBackColor = true;
            this.Btn20.Click += new System.EventHandler(this.Btn20_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMonto);
            this.groupBox1.Controls.Add(this.LblMontoRetirar);
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del retiro";
            // 
            // TxtMonto
            // 
            this.TxtMonto.Enabled = false;
            this.TxtMonto.Location = new System.Drawing.Point(126, 37);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(172, 20);
            this.TxtMonto.TabIndex = 2;
            // 
            // LblMontoRetirar
            // 
            this.LblMontoRetirar.AutoSize = true;
            this.LblMontoRetirar.Location = new System.Drawing.Point(45, 40);
            this.LblMontoRetirar.Name = "LblMontoRetirar";
            this.LblMontoRetirar.Size = new System.Drawing.Size(75, 13);
            this.LblMontoRetirar.TabIndex = 1;
            this.LblMontoRetirar.Text = "Monto a retirar";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(330, 346);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(234, 346);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 15;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // GbDestinatario
            // 
            this.GbDestinatario.Controls.Add(this.CboCuentas);
            this.GbDestinatario.Controls.Add(this.TxtTipoMonedaMisCuentas);
            this.GbDestinatario.Controls.Add(this.label4);
            this.GbDestinatario.Controls.Add(this.label3);
            this.GbDestinatario.Location = new System.Drawing.Point(12, 12);
            this.GbDestinatario.Name = "GbDestinatario";
            this.GbDestinatario.Size = new System.Drawing.Size(393, 83);
            this.GbDestinatario.TabIndex = 19;
            this.GbDestinatario.TabStop = false;
            this.GbDestinatario.Text = "Datos del destinatario";
            // 
            // CboCuentas
            // 
            this.CboCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCuentas.FormattingEnabled = true;
            this.CboCuentas.Location = new System.Drawing.Point(117, 19);
            this.CboCuentas.Name = "CboCuentas";
            this.CboCuentas.Size = new System.Drawing.Size(257, 21);
            this.CboCuentas.TabIndex = 4;
            this.CboCuentas.SelectedIndexChanged += new System.EventHandler(this.CboCuentas_SelectedIndexChanged);
            this.CboCuentas.Validating += new System.ComponentModel.CancelEventHandler(this.CboCuentas_Validating);
            // 
            // TxtTipoMonedaMisCuentas
            // 
            this.TxtTipoMonedaMisCuentas.Enabled = false;
            this.TxtTipoMonedaMisCuentas.Location = new System.Drawing.Point(117, 46);
            this.TxtTipoMonedaMisCuentas.Name = "TxtTipoMonedaMisCuentas";
            this.TxtTipoMonedaMisCuentas.Size = new System.Drawing.Size(257, 20);
            this.TxtTipoMonedaMisCuentas.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo moneda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cuenta";
            // 
            // FrmRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(415, 381);
            this.Controls.Add(this.GbDestinatario);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbEntidad);
            this.Name = "FrmRetiro";
            this.Text = "Retiro";
            this.Load += new System.EventHandler(this.FrmRetiro_Load_1);
            this.GbEntidad.ResumeLayout(false);
            this.GbEntidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudOtroMonto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.GbDestinatario.ResumeLayout(false);
            this.GbDestinatario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbEntidad;
        private System.Windows.Forms.NumericUpDown NudOtroMonto;
        private System.Windows.Forms.Label LblOtroMonto;
        private System.Windows.Forms.Button BtnOtroMonto;
        private System.Windows.Forms.Button Btn3000;
        private System.Windows.Forms.Button Btn500;
        private System.Windows.Forms.Button Btn200;
        private System.Windows.Forms.Button Btn100;
        private System.Windows.Forms.Button Btn50;
        private System.Windows.Forms.Button Btn20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label LblMontoRetirar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblMaximo;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.GroupBox GbDestinatario;
        private System.Windows.Forms.ComboBox CboCuentas;
        private System.Windows.Forms.TextBox TxtTipoMonedaMisCuentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}