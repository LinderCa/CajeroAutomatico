using System;

namespace Cajero_automatico
{
    internal class OperacionRealizada
    {
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Moneda { get; set; }
        public double Monto { get; set; }
    }
}
