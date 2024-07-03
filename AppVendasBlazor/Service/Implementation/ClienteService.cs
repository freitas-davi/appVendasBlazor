using AppVendasBlazor.Data.Context;
using AppVendasBlazor.Model;
using AppVendasBlazor.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace AppVendasBlazor.Service.Implementation
{
    public class ClienteService : IClienteService
    {
        private readonly SQLServerContext _context;

        public ClienteService(SQLServerContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public  async Task AlterarAsync(Cliente cliente)
        {
            _context.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int Id)
        {
            var cliente = await _context.Clientes.FindAsync(Id);
            if (cliente != null) 
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Cliente>> ObterTodosAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> OterPorIdAsync(int Id)
        {
            return await _context.Clientes.FindAsync(Id);
        }
    }
}
