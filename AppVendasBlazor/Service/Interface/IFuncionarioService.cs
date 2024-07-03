using AppVendasBlazor.Model;

namespace AppVendasBlazor.Service.Interface
{
    public interface IFuncionarioService
    {
        Task<IEnumerable<Funcionario>> ObterTodosAsync();
        Task<Funcionario> OterPorIdAsync(int Id);
        Task AdicionarAsync(Funcionario funcionario);
        Task AlterarAsync(Funcionario funcionario);
        Task ExcluirAsync(int Id);
    }
}
