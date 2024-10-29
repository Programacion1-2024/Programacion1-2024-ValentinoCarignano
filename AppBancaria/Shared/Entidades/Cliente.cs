namespace Entidades.Entidades
{
    public class Cliente
    {
        public int ID { get; set; }

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}

        public ICollection<CuentaBancaria> Cuentas { get; set;}
        public ICollection<TarjetaCredito> TarjetasCredito { get; set; }
    }
}