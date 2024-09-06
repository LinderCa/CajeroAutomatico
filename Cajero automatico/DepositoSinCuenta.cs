namespace Cajero_automatico
{
    internal class DepositoSinCuenta : Operacion
    {
        public CuentaBancaria CuentaDestino { get; set; }
        public string Dni { get; set; }
    }
}
