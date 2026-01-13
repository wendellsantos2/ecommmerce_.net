using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using static CasaDoCodigo.Repositories.ProdutoRepository;

namespace CasaDoCodigo
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext contexto, IProdutoRepository produtoRepository)
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            contexto.Database.EnsureCreated();

            List<Livro> livros = GetLivros();

            // Agora compila, pois a interface tem o método
            produtoRepository.SaveProdutos(livros);
        }

        public static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            return JsonConvert.DeserializeObject<List<Livro>>(json) ?? new List<Livro>();
        }
    }
}
