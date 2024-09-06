using System;

namespace Cajero_automatico
{
    internal class MisOperaciones
    {
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Moneda { get; set; }
        public double Monto { get; set; }
        public string CuentaOrigen { get; set; }
    }
}
