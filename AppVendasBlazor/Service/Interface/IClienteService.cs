using AppVendasBlazor.Model;

namespace AppVendasBlazor.Service.Interface
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> ObterTodosAsync();
        Task<Cliente> OterPorIdAsync(int Id);
        Task AdicionarAsync(Cliente cliente);
        Task AlterarAsync(Cliente cliente);
        Task ExcluirAsync(int Id);
    }
}
