using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Cajero_automatico
{
    internal static class Program
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<CuentaBancaria> cuentasBancarias = new List<CuentaBancaria>();
        public static List<Operacion> operaciones = new List<Operacion>();
        public static Cajero cajero = new Cajero();
        public static Administrador administrador;
        public static bool sesionAdministrador = false;


        public static Cliente sesionCliente = new Cliente();
        public static string rutaGuardar = @"D:\";


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LlenarDatos();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }

        private static void LlenarDatos()
        {
            LlenarClientes();
            LlenarCuentasBancarias();
            LlenarCajero();
            LlenarAdministrador();
        }

        private static void LlenarAdministrador()
        {
            administrador = new Administrador()
            {
                Usuario = "admin",
                Contrasenia = "admin123"
            };
        }

        private static void LlenarCajero()
        {
            DineroSoles dineroSoles = new DineroSoles();

            dineroSoles.CantidadBillete20 = 100;
            dineroSoles.CantidadBillete50 = 100;
            dineroSoles.CantidadBillete100 = 100;

            cajero.DineroSoles = dineroSoles;
            cajero.DineroSoles.MontoTotal = 17000;

            DineroDolares dineroDolares = new DineroDolares();

            dineroDolares.CantidadBillete20 = 100;
            dineroDolares.CantidadBillete50 = 100;
            dineroDolares.CantidadBillete100 = 100;

            cajero.DineroDolares = dineroDolares;
            cajero.DineroDolares.MontoTotal = 17000;
        }

        private static void LlenarCuentasBancarias()
        {
            string ruta = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + @"\Cuentas.xlsx");
            SLDocument documento = new SLDocument(ruta);
            int iFila = 2;

            while (!string.IsNullOrEmpty(documento.GetCellValueAsString(iFila, 1)))
            {
                cuentasBancarias.Add(new CuentaBancaria()
                {
                    Cliente = clientes[documento.GetCellValueAsInt32(iFila, 1)],
                    Numero = documento.GetCellValueAsString(iFila, 2),
                    CCI = documento.GetCellValueAsString(iFila, 3),
                    Tipo = documento.GetCellValueAsString(iFila, 4),
                    Saldo = documento.GetCellValueAsDouble(iFila, 5),
                    Vigente = documento.GetCellValueAsInt32(iFila, 6) == 1 ? true : false
                });
                iFila++;

            }
            cuentasBancarias.Add(new CuentaBancaria()
            {
                Cliente = clientes[0],
                Numero = "1234567891012",
                CCI = "12345678901234567890",
                Tipo = "D",
                Saldo = 100000,
                Vigente = true
            });
        }

        private static void LlenarClientes()
        {
            string ruta = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + @"\Clientes.xlsx");
            SLDocument documento = new SLDocument(ruta);
            int iFila = 2;

            while (!string.IsNullOrEmpty(documento.GetCellValueAsString(iFila, 1)))
            {
                clientes.Add(new Cliente()
                {
                    Nombres = documento.GetCellValueAsString(iFila, 1),
                    ApellidoPaterno = documento.GetCellValueAsString(iFila, 2),
                    ApellidoMaterno = documento.GetCellValueAsString(iFila, 3),
                    Genero = documento.GetCellValueAsString(iFila, 4),
                    Dni = documento.GetCellValueAsString(iFila, 5),
                    Contrasenia = documento.GetCellValueAsString(iFila, 6),
                    Vigente = documento.GetCellValueAsInt32(iFila, 7) == 1 ? true : false
                });
                iFila++;
            }
        }
    }
}
