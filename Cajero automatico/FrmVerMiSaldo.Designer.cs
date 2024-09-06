namespace Cajero_automatico
{
    partial class FrmVerMiSaldo
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
            this.BtnEnPantalla = new System.Windows.Forms.Button();
            this.CboCuentas = new System.Windows.Forms.ComboBox();
            this.TxtTipoMonedaMisCuentas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEnVoucher = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEnPantalla
            // 
            this.BtnEnPantalla.Location = new System.Drawing.Point(86, 65);
            this.BtnEnPantalla.Name = "BtnEnPantalla";
            this.BtnEnPantalla.Size = new System.Drawing.Size(127, 23);
            this.BtnEnPantalla.TabIndex = 5;
            this.BtnEnPantalla.Text = "En pantalla";
            this.BtnEnPantalla.UseVisualStyleBackColor = true;
            this.BtnEnPantalla.Click += new System.EventHandler(this.BtnEnPantalla_Click);
            // 
            // CboCuentas
            // 
            this.CboCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCuentas.FormattingEnabled = true;
            this.CboCuentas.Location = new System.Drawing.Point(86, 12);
            this.CboCuentas.Name = "CboCuentas";
            this.CboCuentas.Size = new System.Drawing.Size(257, 21);
            this.CboCuentas.TabIndex = 4;
            this.CboCuentas.SelectedIndexChanged += new System.EventHandler(this.CboCuentas_SelectedIndexChanged);
            this.CboCuentas.Validating += new System.ComponentModel.CancelEventHandler(this.CboCuentas_Validating);
            // 
            // TxtTipoMonedaMisCuentas
            // 
            this.TxtTipoMonedaMisCuentas.Enabled = false;
            this.TxtTipoMonedaMisCuentas.Location = new System.Drawing.Point(86, 39);
            this.TxtTipoMonedaMisCuentas.Name = "TxtTipoMonedaMisCuentas";
            this.TxtTipoMonedaMisCuentas.Size = new System.Drawing.Size(257, 20);
            this.TxtTipoMonedaMisCuentas.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo moneda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cuenta";
            // 
            // BtnEnVoucher
            // 
            this.BtnEnVoucher.Location = new System.Drawing.Point(216, 65);
            this.BtnEnVoucher.Name = "BtnEnVoucher";
            this.BtnEnVoucher.Size = new System.Drawing.Size(127, 23);
            this.BtnEnVoucher.TabIndex = 5;
            this.BtnEnVoucher.Text = "En voucher";
            this.BtnEnVoucher.UseVisualStyleBackColor = true;
            this.BtnEnVoucher.Click += new System.EventHandler(this.BtnEnVoucher_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(264, 129);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(79, 23);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // FrmVerMiSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 164);
            this.Controls.Add(this.BtnEnVoucher);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEnPantalla);
            this.Controls.Add(this.CboCuentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTipoMonedaMisCuentas);
            this.Controls.Add(this.label4);
            this.Name = "FrmVerMiSaldo";
            this.Text = "Ver mi saldo";
            this.Load += new System.EventHandler(this.FrmVerMiSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEnPantalla;
        private System.Windows.Forms.ComboBox CboCuentas;
        private System.Windows.Forms.TextBox TxtTipoMonedaMisCuentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEnVoucher;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
    }
}