using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Application.Commands.DeleteProduto
{
    public class DeleteProdutoCommand : IRequest<Unit>
    {
        public DeleteProdutoCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
