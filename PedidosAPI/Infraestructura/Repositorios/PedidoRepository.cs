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
    private readonly AppDbContext _context;

    public PedidoRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Guardar(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            return;
    }

    public Pedido ObtenerPorId(int id)
    {
        return _context.Pedidos.FirstOrDefault(p => p.Id == id);
    }
}
}