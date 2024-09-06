namespace Cajero_automatico
{
    internal class DepositoConCuenta : Operacion
    {
        public Cliente Cliente { get; set; }
        public CuentaBancaria CuentaDestino { get; set; }
    }
}
