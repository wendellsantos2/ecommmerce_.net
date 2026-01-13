using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories;
using System.Collections.Generic;
using static CasaDoCodigo.Repositories.ProdutoRepository;

namespace CasaDoCodigo
{
    public interface IProdutoRepository
    {
        void SaveProdutos(IEnumerable<Livro> livros);

        IList<Produto> GetProdutos();
    }
}
