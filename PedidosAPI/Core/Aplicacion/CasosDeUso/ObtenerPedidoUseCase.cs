using PedidosAPI.Core.Aplicacion.Interfaces;
using  PedidosAPI.Core.Dominio.Entidades;

namespace PedidosAPI.Core.Aplicacion.CasosDeUso
{

    public class ObtenerPedidoUseCase
    {
        private readonly IPedidoRepository _pedidoRepositorio;

        public ObtenerPedidoUseCase(IPedidoRepository pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
        }

        public Pedido Ejecutar(int id)
        {
            var pedido = _pedidoRepositorio.ObtenerPorId(id);

            if (pedido == null)
                throw new KeyNotFoundException($"Pedido con ID {id} no encontrado");

            return pedido;
        }
    }
}