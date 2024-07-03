using AppVendasBlazor.Model;

namespace AppVendasBlazor.Service.Interface
{
    public interface IPedidoService
    {
        Task<IEnumerable<Pedido>> ObterTodosAsync();
        Task<Pedido> OterPorIdAsync(int Id);
        Task AdicionarAsync(Pedido pedido);
        Task AlterarAsync(Pedido pedido);
        Task ExcluirAsync(int Id);
    }
}
