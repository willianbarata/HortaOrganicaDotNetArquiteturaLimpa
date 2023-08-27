using HortaOrganica.Core.DTOs;
using HortaOrganica.Core.Entities;
using HortaOrganica.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Application.Queries
{
    public class GetAllProdutosQueryHandler : IRequestHandler<GetAllProdutosQuery, List<ProdutoDTO>>
    {
        public readonly IProdutoRepository _produtoRepository;

        public GetAllProdutosQueryHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<List<ProdutoDTO>> Handle(GetAllProdutosQuery request, CancellationToken cancellationToken)
        {
            return await _produtoRepository.GetAll();
        }
    }
}
