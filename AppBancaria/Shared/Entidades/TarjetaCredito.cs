namespace Entidades.Entidades
{
    public class TarjetaCredito
    {
        public int ID { get; set; }

        public int NumeroTarjeta {  get; set; }
        public double LimiteCredito { get; set; }
        public double SaldoDisponible { get; set; }
        public string Estado { get; set; }

        public Cliente Cliente { get; set; }
    }
}