using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cajero_automatico
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (Program.sesionCliente != null || Program.sesionAdministrador == true)
            {
                MnuOpcionesPrivadas.Visible = false;
            }
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuUsuario_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuCuentaBancaria_Click(object sender, EventArgs e)
        {
            FrmCuentaBancaria frm = new FrmCuentaBancaria();

            frm.MdiParent = this;
            frm.Show();
        }


        private void MnuRecargarCajero_Click(object sender, EventArgs e)
        {
            FrmRecargarCajero frm = new FrmRecargarCajero();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuRetiro_Click(object sender, EventArgs e)
        {
            FrmRetiro frm = new FrmRetiro();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuDepositoSinCuenta_Click(object sender, EventArgs e)
        {
            FrmDepositoSinCuenta frm = new FrmDepositoSinCuenta();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuDeposito_Click(object sender, EventArgs e)
        {
            FrmDepositoConCuenta frm = new FrmDepositoConCuenta();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuOperacionesRealizadas_Click(object sender, EventArgs e)
        {
            FrmOperacionesRealizadas frm = new FrmOperacionesRealizadas();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuVerMiSaldo_Click(object sender, EventArgs e)
        {
            FrmVerMiSaldo frm = new FrmVerMiSaldo();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuMisOperaciones_Click(object sender, EventArgs e)
        {
            FrmMisRetiros frm = new FrmMisRetiros();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuListaRetiros_Click(object sender, EventArgs e)
        {
            FrmListaRetiros frm = new FrmListaRetiros();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuListaDepositoSinCuenta_Click(object sender, EventArgs e)
        {
            FrmListaDepositosSinCuenta frm = new FrmListaDepositosSinCuenta();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuListaDepositosConcuenta_Click(object sender, EventArgs e)
        {
            FrmListaDepositoConCuenta frm = new FrmListaDepositoConCuenta();

            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            FrmIniciarSesion frm = new FrmIniciarSesion();
            var cliente = frm.Buscar();
            if (cliente != null)
            {
                Program.sesionCliente = cliente;
                MnuOpcionesPrivadas.Visible = true;
                MnuOpcionPublicas.Visible = false;
                MnuGestion.Visible = false;
                MnuOperaciones.Visible = true;

                MnuOperacionesRealizadas.Visible = false;
                MnuListaRetiros.Visible = false;
                MnuListaDepositoSinCuenta.Visible = false;
                MnuListaDepositosConcuenta.Visible = false;
                MnuMisOperaciones.Visible = true;
                MnuVerMiSaldo.Visible = true;
            }
        }

        private void BtnDepositoSinCuenta_Click(object sender, EventArgs e)
        {
            FrmDepositoSinCuenta frm = new FrmDepositoSinCuenta();

            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnIniciarComoAdministrador_Click(object sender, EventArgs e)
        {
            FrmIniciarSesionAdministrador frm = new FrmIniciarSesionAdministrador();
            var validado = frm.Validar();
            if (validado)
            {
                Program.sesionAdministrador = true;
                MnuOpcionesPrivadas.Visible = true;
                MnuOpcionPublicas.Visible = false;
                MnuGestion.Visible = true;
                MnuOperaciones.Visible = false;

                MnuOperacionesRealizadas.Visible = true;
                MnuListaRetiros.Visible = true;
                MnuListaDepositoSinCuenta.Visible = true;
                MnuListaDepositosConcuenta.Visible = true;
                MnuMisOperaciones.Visible = false;
                MnuVerMiSaldo.Visible = false;
            }
        }

        private void MnuCerrarSesion_Click(object sender, EventArgs e)
        {
            List<Form> formularios = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                formularios.Add(form);
            }

            foreach (Form form in formularios)
            {
                if (form != this)
                {
                    form.Close();
                }
            }

            MnuOpcionesPrivadas.Visible = false;
            MnuOpcionPublicas.Visible = true;
            Program.sesionCliente = null;
            Program.sesionAdministrador = false;
        }


    }
}
