using Microsoft.AspNetCore.Http.HttpResults;
using PedidosAPI.Core.Aplicacion.Interfaces;
using  PedidosAPI.Core.Dominio.Entidades;

namespace PedidosAPI.Core.Aplicacion.CasosDeUso
{
    public class CrearPedidoUseCase
    {
        private readonly IPedidoRepository _repository;

        public CrearPedidoUseCase(IPedidoRepository repository)
        {
            _repository = repository;
        }

        public void Ejecutar(Pedido pedido)
        {
            if (pedido.CalcularTotal() == 0)
            {
                throw new InvalidOperationException("El pedido no puede estar vacío.");
            }

            _repository.Guardar(pedido);

            return;
        }
    }
}