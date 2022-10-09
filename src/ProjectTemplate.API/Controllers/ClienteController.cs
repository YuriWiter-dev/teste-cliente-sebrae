using Microsoft.AspNetCore.Mvc;
using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Application.Interfaces;
using ProjectTemplate.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace ProjectTemplate.API.Controllers
{
    public class ClienteController : CoreController<Cliente, ClienteDto>
    {
        protected readonly IClienteApp _clienteApp;

        public ClienteController(IClienteApp cliente) : base(cliente)
        {
            _clienteApp = cliente;
        }

        [HttpGet]
        [Route("consulta-final-placa/{numero}")]
        public async Task<IActionResult> SelecionarPorUltimoNumeroPlaca(string numero)
        {
            try
            {
                var objById = await _clienteApp.BuscarTodosComPesquisa(
                        c => c.PlacaCarro.EndsWith(numero)
                    );
                return new OkObjectResult(objById);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
