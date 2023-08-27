using HortaOrganica.Core.DTOs;
using HortaOrganica.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Application.Queries
{
    public class GetAllProdutosQuery : IRequest<List<ProdutoDTO>>
    {
        public GetAllProdutosQuery(string query)
        {
            Query = query;
        }
        public string Query { get; private set; }
    }
}
