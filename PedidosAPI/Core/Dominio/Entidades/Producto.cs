namespace PedidosAPI.Core.Dominio.Entidades
{
    public class Producto
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public decimal Precio { get; private set; }

        public Producto(int id, string nombre, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }
    }
}