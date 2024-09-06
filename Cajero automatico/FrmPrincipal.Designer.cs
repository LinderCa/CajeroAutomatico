namespace Cajero_automatico
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MnuOpcionesPrivadas = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCuentaBancaria = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRecargarCajero = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRetiro = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDeposito = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOperacionesRealizadas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMisOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListaRetiros = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListaDepositoSinCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListaDepositosConcuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVerMiSaldo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpcionPublicas = new System.Windows.Forms.ToolStrip();
            this.BtnIniciarSesion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDepositoSinCuenta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnIniciarComoAdministrador = new System.Windows.Forms.ToolStripButton();
            this.MnuOpcionesPrivadas.SuspendLayout();
            this.MnuOpcionPublicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuOpcionesPrivadas
            // 
            this.MnuOpcionesPrivadas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.MnuGestion,
            this.MnuOperaciones,
            this.reportesToolStripMenuItem});
            this.MnuOpcionesPrivadas.Location = new System.Drawing.Point(0, 0);
            this.MnuOpcionesPrivadas.Name = "MnuOpcionesPrivadas";
            this.MnuOpcionesPrivadas.Size = new System.Drawing.Size(1055, 24);
            this.MnuOpcionesPrivadas.TabIndex = 0;
            this.MnuOpcionesPrivadas.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCerrarSesion});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.archivoToolStripMenuItem.Text = "Sesión";
            // 
            // MnuCerrarSesion
            // 
            this.MnuCerrarSesion.Name = "MnuCerrarSesion";
            this.MnuCerrarSesion.Size = new System.Drawing.Size(106, 22);
            this.MnuCerrarSesion.Text = "Cerrar";
            this.MnuCerrarSesion.Click += new System.EventHandler(this.MnuCerrarSesion_Click);
            // 
            // MnuGestion
            // 
            this.MnuGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuUsuario,
            this.MnuCuentaBancaria,
            this.MnuRecargarCajero});
            this.MnuGestion.Name = "MnuGestion";
            this.MnuGestion.Size = new System.Drawing.Size(59, 20);
            this.MnuGestion.Text = "Gestión";
            // 
            // MnuUsuario
            // 
            this.MnuUsuario.Name = "MnuUsuario";
            this.MnuUsuario.Size = new System.Drawing.Size(180, 22);
            this.MnuUsuario.Text = "Cliente";
            this.MnuUsuario.Click += new System.EventHandler(this.MnuUsuario_Click);
            // 
            // MnuCuentaBancaria
            // 
            this.MnuCuentaBancaria.Name = "MnuCuentaBancaria";
            this.MnuCuentaBancaria.Size = new System.Drawing.Size(180, 22);
            this.MnuCuentaBancaria.Text = "Cuenta bancaria";
            this.MnuCuentaBancaria.Click += new System.EventHandler(this.MnuCuentaBancaria_Click);
            // 
            // MnuRecargarCajero
            // 
            this.MnuRecargarCajero.Name = "MnuRecargarCajero";
            this.MnuRecargarCajero.Size = new System.Drawing.Size(180, 22);
            this.MnuRecargarCajero.Text = "Recargar cajero";
            this.MnuRecargarCajero.Click += new System.EventHandler(this.MnuRecargarCajero_Click);
            // 
            // MnuOperaciones
            // 
            this.MnuOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRetiro,
            this.MnuDeposito});
            this.MnuOperaciones.Name = "MnuOperaciones";
            this.MnuOperaciones.Size = new System.Drawing.Size(85, 20);
            this.MnuOperaciones.Text = "Operaciones";
            // 
            // MnuRetiro
            // 
            this.MnuRetiro.Name = "MnuRetiro";
            this.MnuRetiro.Size = new System.Drawing.Size(121, 22);
            this.MnuRetiro.Text = "Retiro";
            this.MnuRetiro.Click += new System.EventHandler(this.MnuRetiro_Click);
            // 
            // MnuDeposito
            // 
            this.MnuDeposito.Name = "MnuDeposito";
            this.MnuDeposito.Size = new System.Drawing.Size(121, 22);
            this.MnuDeposito.Text = "Depósito";
            this.MnuDeposito.Click += new System.EventHandler(this.MnuDeposito_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuOperacionesRealizadas,
            this.MnuMisOperaciones,
            this.MnuListaRetiros,
            this.MnuListaDepositoSinCuenta,
            this.MnuListaDepositosConcuenta,
            this.MnuVerMiSaldo});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // MnuOperacionesRealizadas
            // 
            this.MnuOperacionesRealizadas.Name = "MnuOperacionesRealizadas";
            this.MnuOperacionesRealizadas.Size = new System.Drawing.Size(230, 22);
            this.MnuOperacionesRealizadas.Text = "Operaciones realizadas";
            this.MnuOperacionesRealizadas.Click += new System.EventHandler(this.MnuOperacionesRealizadas_Click);
            // 
            // MnuMisOperaciones
            // 
            this.MnuMisOperaciones.Name = "MnuMisOperaciones";
            this.MnuMisOperaciones.Size = new System.Drawing.Size(230, 22);
            this.MnuMisOperaciones.Text = "Mis retiros";
            this.MnuMisOperaciones.Click += new System.EventHandler(this.MnuMisOperaciones_Click);
            // 
            // MnuListaRetiros
            // 
            this.MnuListaRetiros.Name = "MnuListaRetiros";
            this.MnuListaRetiros.Size = new System.Drawing.Size(230, 22);
            this.MnuListaRetiros.Text = "Lista de retiros";
            this.MnuListaRetiros.Click += new System.EventHandler(this.MnuListaRetiros_Click);
            // 
            // MnuListaDepositoSinCuenta
            // 
            this.MnuListaDepositoSinCuenta.Name = "MnuListaDepositoSinCuenta";
            this.MnuListaDepositoSinCuenta.Size = new System.Drawing.Size(230, 22);
            this.MnuListaDepositoSinCuenta.Text = "Lista de depósitos sin cuenta";
            this.MnuListaDepositoSinCuenta.Click += new System.EventHandler(this.MnuListaDepositoSinCuenta_Click);
            // 
            // MnuListaDepositosConcuenta
            // 
            this.MnuListaDepositosConcuenta.Name = "MnuListaDepositosConcuenta";
            this.MnuListaDepositosConcuenta.Size = new System.Drawing.Size(230, 22);
            this.MnuListaDepositosConcuenta.Text = "Lista de depóstios con cuenta";
            this.MnuListaDepositosConcuenta.Click += new System.EventHandler(this.MnuListaDepositosConcuenta_Click);
            // 
            // MnuVerMiSaldo
            // 
            this.MnuVerMiSaldo.Name = "MnuVerMiSaldo";
            this.MnuVerMiSaldo.Size = new System.Drawing.Size(230, 22);
            this.MnuVerMiSaldo.Text = "Ver mi saldo";
            this.MnuVerMiSaldo.Click += new System.EventHandler(this.MnuVerMiSaldo_Click);
            // 
            // MnuOpcionPublicas
            // 
            this.MnuOpcionPublicas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnIniciarSesion,
            this.toolStripSeparator2,
            this.BtnDepositoSinCuenta,
            this.toolStripSeparator3,
            this.BtnIniciarComoAdministrador});
            this.MnuOpcionPublicas.Location = new System.Drawing.Point(0, 24);
            this.MnuOpcionPublicas.Name = "MnuOpcionPublicas";
            this.MnuOpcionPublicas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MnuOpcionPublicas.Size = new System.Drawing.Size(1055, 25);
            this.MnuOpcionPublicas.TabIndex = 3;
            this.MnuOpcionPublicas.Text = "toolStrip1";
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnIniciarSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnIniciarSesion.Image")));
            this.BtnIniciarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(79, 22);
            this.BtnIniciarSesion.Text = "Iniciar sesión";
            this.BtnIniciarSesion.ToolTipText = "Iniciar sesión";
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnDepositoSinCuenta
            // 
            this.BtnDepositoSinCuenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnDepositoSinCuenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnDepositoSinCuenta.Image")));
            this.BtnDepositoSinCuenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDepositoSinCuenta.Name = "BtnDepositoSinCuenta";
            this.BtnDepositoSinCuenta.Size = new System.Drawing.Size(115, 22);
            this.BtnDepositoSinCuenta.Text = "Depósito sin cuenta";
            this.BtnDepositoSinCuenta.Click += new System.EventHandler(this.BtnDepositoSinCuenta_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnIniciarComoAdministrador
            // 
            this.BtnIniciarComoAdministrador.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnIniciarComoAdministrador.Image = ((System.Drawing.Image)(resources.GetObject("BtnIniciarComoAdministrador.Image")));
            this.BtnIniciarComoAdministrador.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnIniciarComoAdministrador.Name = "BtnIniciarComoAdministrador";
            this.BtnIniciarComoAdministrador.Size = new System.Drawing.Size(154, 22);
            this.BtnIniciarComoAdministrador.Text = "Iniciar como administrador";
            this.BtnIniciarComoAdministrador.Click += new System.EventHandler(this.BtnIniciarComoAdministrador_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1055, 714);
            this.Controls.Add(this.MnuOpcionPublicas);
            this.Controls.Add(this.MnuOpcionesPrivadas);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuOpcionesPrivadas;
            this.Name = "FrmPrincipal";
            this.Text = "Cajero automático";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MnuOpcionesPrivadas.ResumeLayout(false);
            this.MnuOpcionesPrivadas.PerformLayout();
            this.MnuOpcionPublicas.ResumeLayout(false);
            this.MnuOpcionPublicas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuOpcionesPrivadas;
        private System.Windows.Forms.ToolStripMenuItem MnuGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem MnuCuentaBancaria;
        private System.Windows.Forms.ToolStripMenuItem MnuRecargarCajero;
        private System.Windows.Forms.ToolStripMenuItem MnuOperaciones;
        private System.Windows.Forms.ToolStripMenuItem MnuDeposito;
        private System.Windows.Forms.ToolStripMenuItem MnuRetiro;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuOperacionesRealizadas;
        private System.Windows.Forms.ToolStripMenuItem MnuMisOperaciones;
        private System.Windows.Forms.ToolStripMenuItem MnuListaRetiros;
        private System.Windows.Forms.ToolStripMenuItem MnuListaDepositoSinCuenta;
        private System.Windows.Forms.ToolStripMenuItem MnuListaDepositosConcuenta;
        private System.Windows.Forms.ToolStripMenuItem MnuVerMiSaldo;
        private System.Windows.Forms.ToolStrip MnuOpcionPublicas;
        private System.Windows.Forms.ToolStripButton BtnIniciarSesion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnDepositoSinCuenta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtnIniciarComoAdministrador;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuCerrarSesion;
    }
}