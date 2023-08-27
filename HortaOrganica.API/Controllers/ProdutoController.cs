using HortaOrganica.Application.Commands.CreateProduto;
using HortaOrganica.Application.Commands.DeleteProduto;
using HortaOrganica.Application.Commands.UpdateProduto;
using HortaOrganica.Application.InputModels;
using HortaOrganica.Application.Queries;
using HortaOrganica.Core.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HortaOrganica.API.Controllers
{
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        public readonly IMediator _mediator;
        public ProdutoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(string query)
        {
            var getAllProdutoQuery = new GetAllProdutosQuery(query);
            var listaProdutos = await _mediator.Send(getAllProdutoQuery);
            return Ok(listaProdutos);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProdutoCommand command)
        {
            var produtoCriado = await _mediator.Send(command);
            return Ok(produtoCriado);
        }

        [HttpPut]
        public async Task<IActionResult> Post([FromBody] UpdateProdutoCommand command)
        {
            var produtoAlterado = await _mediator.Send(command);
            return Ok(produtoAlterado);
        }

        [HttpDelete]
        public async Task<IActionResult> Post([FromBody] DeleteProdutoCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }


    }
}
