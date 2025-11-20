namespace PedidosAPI.Core.Dominio.ValuesObjects
{
    public class Direccion
    {
        public string Calle { get; }
        public string Ciudad { get; }
        public string CodigoPostal { get; }

        public Direccion(string calle, string ciudad, string codigoPostal)
        {
            Calle = calle;
            Ciudad = ciudad;
            CodigoPostal = codigoPostal;
        }
    }
}