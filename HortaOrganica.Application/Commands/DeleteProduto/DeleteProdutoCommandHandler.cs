using HortaOrganica.Core.Entities;
using HortaOrganica.Core.Repositories;
using HortaOrganica.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Application.Commands.DeleteProduto
{
    internal class DeleteProdutoCommandHandler : IRequestHandler<DeleteProdutoCommand, Unit>
    {
        private readonly IProdutoRepository _produtoRepository;

        public DeleteProdutoCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<Unit> Handle(DeleteProdutoCommand request, CancellationToken cancellationToken)
        {
            var produtoExcluido = await _produtoRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
