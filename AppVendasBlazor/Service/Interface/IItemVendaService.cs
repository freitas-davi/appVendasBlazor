using AppVendasBlazor.Model;

namespace AppVendasBlazor.Service.Interface
{
    public interface IItemVendaService
    {
        Task AdicionarAsync(ItemVenda itemVenda);
        Task ExcluirAsync(int Id);
    }
}
