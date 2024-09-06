namespace Cajero_automatico
{
    partial class FrmCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.GbEntidad = new System.Windows.Forms.GroupBox();
            this.CboGenero = new System.Windows.Forms.ComboBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtApMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.CdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtCerrar = new System.Windows.Forms.Button();
            this.GbEntidad.SuspendLayout();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(86, 28);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(218, 20);
            this.TxtNombres.TabIndex = 1;
            this.TxtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ap. Paterno";
            // 
            // TxtApPaterno
            // 
            this.TxtApPaterno.Location = new System.Drawing.Point(86, 54);
            this.TxtApPaterno.Name = "TxtApPaterno";
            this.TxtApPaterno.Size = new System.Drawing.Size(218, 20);
            this.TxtApPaterno.TabIndex = 1;
            this.TxtApPaterno.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DNI";
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(86, 133);
            this.TxtDni.MaxLength = 8;
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(218, 20);
            this.TxtDni.TabIndex = 1;
            this.TxtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDni_KeyPress);
            this.TxtDni.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // GbEntidad
            // 
            this.GbEntidad.Controls.Add(this.CboGenero);
            this.GbEntidad.Controls.Add(this.LblGenero);
            this.GbEntidad.Controls.Add(this.ChkVigente);
            this.GbEntidad.Controls.Add(this.TxtContrasenia);
            this.GbEntidad.Controls.Add(this.label5);
            this.GbEntidad.Controls.Add(this.TxtDni);
            this.GbEntidad.Controls.Add(this.BtnCancelar);
            this.GbEntidad.Controls.Add(this.label3);
            this.GbEntidad.Controls.Add(this.BtnAceptar);
            this.GbEntidad.Controls.Add(this.TxtApMaterno);
            this.GbEntidad.Controls.Add(this.TxtApPaterno);
            this.GbEntidad.Controls.Add(this.label4);
            this.GbEntidad.Controls.Add(this.TxtNombres);
            this.GbEntidad.Controls.Add(this.label2);
            this.GbEntidad.Controls.Add(this.label1);
            this.GbEntidad.Enabled = false;
            this.GbEntidad.Location = new System.Drawing.Point(12, 12);
            this.GbEntidad.Name = "GbEntidad";
            this.GbEntidad.Size = new System.Drawing.Size(336, 274);
            this.GbEntidad.TabIndex = 2;
            this.GbEntidad.TabStop = false;
            this.GbEntidad.Text = "Usuario";
            // 
            // CboGenero
            // 
            this.CboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboGenero.FormattingEnabled = true;
            this.CboGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.CboGenero.Location = new System.Drawing.Point(86, 106);
            this.CboGenero.Name = "CboGenero";
            this.CboGenero.Size = new System.Drawing.Size(218, 21);
            this.CboGenero.TabIndex = 11;
            this.CboGenero.Validating += new System.ComponentModel.CancelEventHandler(this.CboGenero_Validating);
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Location = new System.Drawing.Point(17, 109);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(42, 13);
            this.LblGenero.TabIndex = 10;
            this.LblGenero.Text = "Género";
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(86, 200);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 10;
            this.ChkVigente.Text = "Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(86, 163);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '*';
            this.TxtContrasenia.Size = new System.Drawing.Size(218, 20);
            this.TxtContrasenia.TabIndex = 1;
            this.TxtContrasenia.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contraseña";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(229, 237);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(133, 237);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtApMaterno
            // 
            this.TxtApMaterno.Location = new System.Drawing.Point(86, 80);
            this.TxtApMaterno.Name = "TxtApMaterno";
            this.TxtApMaterno.Size = new System.Drawing.Size(218, 20);
            this.TxtApMaterno.TabIndex = 1;
            this.TxtApMaterno.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ap. Materno";
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
            this.GbListado.Location = new System.Drawing.Point(354, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(505, 454);
            this.GbListado.TabIndex = 3;
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
            this.CdNombre,
            this.CdDni,
            this.CdVigente});
            this.DgvListado.Location = new System.Drawing.Point(17, 50);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(473, 346);
            this.DgvListado.TabIndex = 1;
            // 
            // CdNombre
            // 
            this.CdNombre.DataPropertyName = "NombreCompleto";
            this.CdNombre.HeaderText = "Nombre";
            this.CdNombre.Name = "CdNombre";
            this.CdNombre.ReadOnly = true;
            // 
            // CdDni
            // 
            this.CdDni.DataPropertyName = "Dni";
            this.CdDni.HeaderText = "DNI";
            this.CdDni.Name = "CdDni";
            this.CdDni.ReadOnly = true;
            // 
            // CdVigente
            // 
            this.CdVigente.DataPropertyName = "Vigente";
            this.CdVigente.HeaderText = "Vigente";
            this.CdVigente.Name = "CdVigente";
            this.CdVigente.ReadOnly = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Location = new System.Drawing.Point(113, 413);
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
            this.BtnListar.Location = new System.Drawing.Point(415, 21);
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
            this.BtnNuevo.Location = new System.Drawing.Point(17, 413);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // TxtCerrar
            // 
            this.TxtCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCerrar.Location = new System.Drawing.Point(784, 472);
            this.TxtCerrar.Name = "TxtCerrar";
            this.TxtCerrar.Size = new System.Drawing.Size(75, 23);
            this.TxtCerrar.TabIndex = 4;
            this.TxtCerrar.Text = "C&errar";
            this.TxtCerrar.UseVisualStyleBackColor = true;
            this.TxtCerrar.Click += new System.EventHandler(this.TxtCerrar_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(871, 507);
            this.Controls.Add(this.TxtCerrar);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbEntidad);
            this.Name = "FrmCliente";
            this.Text = "Gestión cliente";
            this.GbEntidad.ResumeLayout(false);
            this.GbEntidad.PerformLayout();
            this.GbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.GroupBox GbEntidad;
        private System.Windows.Forms.ComboBox CboGenero;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtApMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.Button TxtCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdDni;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CdVigente;
    }
}

