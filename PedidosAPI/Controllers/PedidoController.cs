using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PedidosAPI.Core.Dominio.Entidades;
using PedidosAPI.Core.Aplicacion.CasosDeUso;

namespace PedidosAPI.Controller
{
    [ApiController]
[Route("api/pedidos")]
public class PedidoController : ControllerBase
{
    private readonly CrearPedidoUseCase _crearPedidoUseCase;
    private readonly ObtenerPedidoUseCase _obtenerPedidoUseCase;

    public PedidoController(CrearPedidoUseCase crearPedidoUseCase, ObtenerPedidoUseCase obtenerPedidoUseCase)
    {
        _crearPedidoUseCase = crearPedidoUseCase;
        _obtenerPedidoUseCase = obtenerPedidoUseCase;
    }

    [HttpPost]
    public IActionResult CrearPedido([FromBody] Pedido pedido)
    {
        try
        {
            _crearPedidoUseCase.Ejecutar(pedido);
            return Ok("Pedido creado exitosamente");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public IActionResult ObtenerPedido(int id)
    {
        try
        {
            var pedido = _obtenerPedidoUseCase.Ejecutar(id);
            return Ok(pedido);
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}
}