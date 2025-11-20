using Microsoft.AspNetCore.Http.HttpResults;
using PedidosAPI.Core.Aplicacion.Interfaces;
using PedidosAPI.Core.Dominio.Entidades;

namespace PedidosAPI.Core.Aplicacion.CasosDeUso
{
    public class EliminarPedidoUseCase
    {
        private readonly IPedidoRepository _pedidoRepositorio;

        public EliminarPedidoUseCase(IPedidoRepository pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
        }

        public void Ejecutar(int id)
        {
            if (!_pedidoRepositorio.Existe(id))
                throw new KeyNotFoundException($"No se puede eliminar. El pedido con ID {id} no existe.");

            _pedidoRepositorio.Eliminar(id);
        }
    }
}
