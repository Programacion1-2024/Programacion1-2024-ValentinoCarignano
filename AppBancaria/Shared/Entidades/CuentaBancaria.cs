namespace Entidades.Entidades
{
    public class CuentaBancaria
    {
        public int ID { get; set; }

        public int NumeroCuenta { get; set; }
        public double Saldo { get; set; }
        public string TipoCuenta { get; set; }

        public Cliente Cliente { get; set; }
    }
}