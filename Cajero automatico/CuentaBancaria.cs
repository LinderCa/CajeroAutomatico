namespace Cajero_automatico
{
    internal class CuentaBancaria
    {
        public Cliente Cliente { get; set; }
        public string Numero { get; set; }
        public string CCI { get; set; }
        public string Tipo { get; set; }
        public double Saldo { get; set; }
        public bool Vigente { get; set; }

        public string NombreCliente
        {
            get { return $"{Cliente.Nombres} {Cliente.ApellidoPaterno} {Cliente.ApellidoMaterno}"; }
        }

        public string NombreTipoMoneda
        {
            get
            {
                string cadena = "";
                if (Tipo.Equals("S"))
                {
                    cadena = "Soles";
                }
                else
                {
                    cadena = "Dólares";
                }
                return cadena;
            }
        }
    }
}
