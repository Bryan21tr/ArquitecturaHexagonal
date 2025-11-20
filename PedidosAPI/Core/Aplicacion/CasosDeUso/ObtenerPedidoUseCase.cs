using PedidosAPI.Core.Aplicacion.Interfaces;
using  PedidosAPI.Core.Dominio.Entidades;

namespace PedidosAPI.Core.Aplicacion.CasosDeUso
{

    public class ObtenerPedidoUseCase
    {
        private readonly IPedidoRepository _repository;

        public ObtenerPedidoUseCase(IPedidoRepository repository)
        {
            _repository = repository;
        }

        public Pedido Ejecutar(int id)
        {
            var pedido = _repository.ObtenerPorId(id);

            if (pedido == null)
            {
                throw new KeyNotFoundException("Pedido no encontrado.");
            }

            return pedido;
        }
    }
}