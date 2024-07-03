using AppVendasBlazor.Data.Context;
using AppVendasBlazor.Model;
using AppVendasBlazor.Service.Interface;

namespace AppVendasBlazor.Service.Implementation
{
    public class PedidoService : IPedidoService
    {
        private readonly SQLServerContext _context;

        public PedidoService(SQLServerContext context)
        {
            _context = context;
        }

        public Task AdicionarAsync(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Task AlterarAsync(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pedido>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Pedido> OterPorIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
