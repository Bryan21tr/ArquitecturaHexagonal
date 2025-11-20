using Microsoft.AspNetCore.Http.HttpResults;
using PedidosAPI.Core.Aplicacion.Interfaces;
using  PedidosAPI.Core.Dominio.Entidades;

namespace PedidosAPI.Core.Aplicacion.CasosDeUso
{
    public class CrearPedidoUseCase
    {
        private readonly IPedidoRepository _pedidoRepositorio;

         public CrearPedidoUseCase(IPedidoRepository pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
        }

        public void Ejecutar(Pedido pedido)
        {
            if (pedido == null)
                throw new ArgumentException("El pedido no puede ser nulo");

            _pedidoRepositorio.Crear(pedido);
        }
    }
}