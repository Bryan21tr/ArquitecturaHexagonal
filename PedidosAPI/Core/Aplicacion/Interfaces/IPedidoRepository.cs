using PedidosAPI.Core.Dominio.Entidades;

namespace PedidosAPI.Core.Aplicacion.Interfaces
{

    public interface IPedidoRepository
    {
        void Guardar(Pedido pedido);
        Pedido ObtenerPorId(int id);
    }
}