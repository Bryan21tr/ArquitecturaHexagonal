using PedidosAPI.Core.Dominio.Entidades;

namespace PedidosAPI.Core.Aplicacion.Interfaces
{

    public interface IPedidoRepository
    {
        void Crear(Pedido pedido);
        Pedido ObtenerPorId(int id);
        List<Pedido> ObtenerTodos();
        void Actualizar(Pedido pedido);
        void Eliminar(int id);
        bool Existe(int id);
    }
}