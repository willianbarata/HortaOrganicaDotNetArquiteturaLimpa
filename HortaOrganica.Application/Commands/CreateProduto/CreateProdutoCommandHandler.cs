using HortaOrganica.Core.Entities;
using HortaOrganica.Core.Repositories;
using HortaOrganica.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Application.Commands.CreateProduto
{
    public class CreateProdutoCommandHandler : IRequestHandler<CreateProdutoCommand, int>
    {
        public readonly IProdutoRepository _produtoRepository;
        public CreateProdutoCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<int> Handle(CreateProdutoCommand request, CancellationToken cancellationToken)
        {
            var produto = new Produto(request.Nome, request.Descricao, request.Preco);

            await _produtoRepository.AddAsync(produto);
            return produto.Id;

        }
    }
}
