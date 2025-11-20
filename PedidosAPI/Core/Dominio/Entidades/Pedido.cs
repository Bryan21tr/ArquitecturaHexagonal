
namespace PedidosAPI.Core.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; private set; }
        public string Cliente { get; private set; }
        private readonly List<Producto> _productos = new List<Producto>();

        public IReadOnlyCollection<Producto> Productos => _productos.AsReadOnly();

        public Pedido(int id, string cliente)
        {
            Id = id;
            Cliente = cliente;
        }

        public void AgregarProducto(Producto producto)
        {
            _productos.Add(producto);
        }

        public decimal CalcularTotal()
        {
            return _productos.Sum(p => p.Precio);
        }
    }
}