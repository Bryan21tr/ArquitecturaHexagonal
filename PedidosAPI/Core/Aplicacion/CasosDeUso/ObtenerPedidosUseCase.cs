using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using PedidosAPI.Core.Aplicacion.Interfaces;
using  PedidosAPI.Core.Dominio.Entidades;


namespace PedidosAPI.Core.Aplicacion.CasosDeUso
{
    public class ObtenerPedidosUseCase
    {
                private readonly IPedidoRepository _pedidoRepositorio;

        public ObtenerPedidosUseCase(IPedidoRepository pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
        }

        public List<Pedido> Ejecutar()
        {
            return _pedidoRepositorio.ObtenerTodos();
        }
    }
}