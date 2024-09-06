using System;

namespace Cajero_automatico
{
    internal abstract class Operacion
    {
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }

    }
}
