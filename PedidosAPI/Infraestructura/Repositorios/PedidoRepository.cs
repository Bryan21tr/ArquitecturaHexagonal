using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PedidosAPI.Core.Aplicacion.Interfaces;
using PedidosAPI.Core.Dominio.Entidades;
using PedidosAPI.Configuracion;
using Microsoft.AspNetCore.Http.HttpResults;

namespace PedidosAPI.Infeaestructura.Repositorios
{
public class PedidoRepository : IPedidoRepository
{
        private readonly PedidosDbContext _context;

    public PedidoRepository(PedidosDbContext context)
        {
            _context = context;
        }

        public void Crear(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        public Pedido ObtenerPorId(int id)
        {
            return _context.Pedidos.Find(id);
        }

        public List<Pedido> ObtenerTodos()
        {
            return _context.Pedidos.ToList();
        }

        public void Actualizar(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                _context.SaveChanges();
            }
        }

        public bool Existe(int id)
        {
            return _context.Pedidos.Any(p => p.id == id);
        }
}
}