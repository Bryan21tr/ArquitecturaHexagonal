using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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
        private readonly ObtenerPedidosUseCase _obtenerPedidosUseCase;
        private readonly ActualizarPedidoUseCase _actualizarPedidoUseCase;
        private readonly EliminarPedidoUseCase _eliminarPedidoUseCase;

        public PedidoController(
            CrearPedidoUseCase crearPedidoUseCase,
            ObtenerPedidoUseCase obtenerPedidoUseCase,
            ObtenerPedidosUseCase obtenerPedidosUseCase,
            ActualizarPedidoUseCase actualizarPedidoUseCase,
            EliminarPedidoUseCase eliminarPedidoUseCase)
        {
            _crearPedidoUseCase = crearPedidoUseCase;
            _obtenerPedidoUseCase = obtenerPedidoUseCase;
            _obtenerPedidosUseCase = obtenerPedidosUseCase;
            _actualizarPedidoUseCase = actualizarPedidoUseCase;
            _eliminarPedidoUseCase = eliminarPedidoUseCase;
        }

        // CREATE
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

        // READ by ID
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

        // READ ALL
        [HttpGet]
        public IActionResult ObtenerPedidos()
        {
              Console.WriteLine("Entró al método ObtenerPedidos");
    try
    {
        var pedidos = _obtenerPedidosUseCase.Ejecutar();
        return Ok(pedidos);
    }
    catch (Exception ex)
    {
        return BadRequest(ex.Message);
    }
        }

        // UPDATE
        [HttpPatch("{id}")]
        public IActionResult ActualizarPedido(int id, [FromBody] Pedido pedido)
        {
            try
            {
                pedido.id = id; // asegurar que coincide el id
                _actualizarPedidoUseCase.Ejecutar(pedido);
                return Ok("Pedido actualizado correctamente");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult EliminarPedido(int id)
        {
            try
            {
                _eliminarPedidoUseCase.Ejecutar(id);
                return Ok("Pedido eliminado correctamente");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
