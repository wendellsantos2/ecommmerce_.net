using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface IItemPedidoRepository
    {
        // coloque aqui os métodos do repositório, se precisar
        // ex: Pedido GetById(int id);
    }

    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
