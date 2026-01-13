using CasaDoCodigo.Models;
using System.Collections.Generic;
using System.Linq;

namespace CasaDoCodigo.Repositories
{
    public class CadastroRepository : BaseRepository<Produto>, ICadastroRepository
    {
        private readonly ApplicationContext _contexto;

        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {
            _contexto = contexto; // <- FALTAVA ISSO
        }

        public IList<Produto> GetProdutos()
        {
            return dbSet.ToList(); // ok se BaseRepository inicializa dbSet
        }

        public void SaveProdutos(IEnumerable<Livro> livros)
        {
            foreach (var livro in livros)
            {
                _contexto.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
            }

            _contexto.SaveChanges();
        }
    }
}
