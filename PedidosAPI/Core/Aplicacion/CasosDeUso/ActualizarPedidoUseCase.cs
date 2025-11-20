using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using PedidosAPI.Core.Aplicacion.Interfaces;
using  PedidosAPI.Core.Dominio.Entidades;


namespace PedidosAPI.Core.Aplicacion.CasosDeUso
{
    public class ActualizarPedidoUseCase
    {
        private readonly IPedidoRepository _pedidoRepositorio;

        public ActualizarPedidoUseCase(IPedidoRepository pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
        }

        public void Ejecutar(Pedido pedido)
        {
            if (!_pedidoRepositorio.Existe(pedido.id))
                throw new KeyNotFoundException($"No se puede actualizar. El pedido con ID {pedido.id} no existe.");

            _pedidoRepositorio.Actualizar(pedido);
        }
    }
}