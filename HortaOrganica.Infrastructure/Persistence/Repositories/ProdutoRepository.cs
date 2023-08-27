using HortaOrganica.Core.DTOs;
using HortaOrganica.Core.Entities;
using HortaOrganica.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Infrastructure.Persistence.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly HortaOrganicaDbContext _dbContext;

        public ProdutoRepository(HortaOrganicaDbContext hortaOrganicaDbContext)
        {
            _dbContext = hortaOrganicaDbContext;
        }

        public async Task<List<ProdutoDTO>> GetAll()
        {
            var produtos = _dbContext.Produtos;
            var listProdutoDTO = await produtos.Select(p => new ProdutoDTO(p.Id, p.Nome, p.Descricao, p.Preco))
                            .ToListAsync();
            return listProdutoDTO;
        }
        public async Task<Produto> AddAsync(Produto produto)
        {
            await _dbContext.Produtos.AddAsync(produto);
            await _dbContext.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> GetById(int id)
        {
            return await _dbContext.Produtos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Produto> Update(Produto produto)
        {
            _dbContext.Update(produto);
            await _dbContext.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> Delete(int id)
        {
             var produto = await GetById(id);
             _dbContext.Produtos.Remove(produto);
             await _dbContext.SaveChangesAsync();
            return produto;
        }

    }
}
