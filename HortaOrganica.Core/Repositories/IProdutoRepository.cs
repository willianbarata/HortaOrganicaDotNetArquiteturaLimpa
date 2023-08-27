using HortaOrganica.Core.DTOs;
using HortaOrganica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Core.Repositories
{
    public interface IProdutoRepository
    {
        Task<List<ProdutoDTO>> GetAll();
        Task<Produto> AddAsync(Produto produto);
        Task<Produto> GetById(int id);
        Task<Produto> Update(Produto produto);
        Task<Produto> Delete(int id);

    }
}
