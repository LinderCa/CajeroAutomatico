namespace Cajero_automatico
{
    internal class Retiro : Operacion
    {
        public Cliente Cliente { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }
    }
}
