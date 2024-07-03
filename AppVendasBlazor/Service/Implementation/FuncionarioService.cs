using AppVendasBlazor.Data.Context;
using AppVendasBlazor.Model;
using AppVendasBlazor.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace AppVendasBlazor.Service.Implementation
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly SQLServerContext _context;

        public FuncionarioService(SQLServerContext context)
        {
            _context = context;
        }
        public async Task AdicionarAsync(Funcionario funcionario)
        {
            await _context.Funcionarios.AddAsync(funcionario);
            await _context.SaveChangesAsync();
        }
        public async Task ExcluirAsync(int Id)
        {
            var cliente = await _context.Funcionarios.FindAsync(Id);
            if (cliente != null) 
            {
                _context.Funcionarios.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
        public async Task AlterarAsync(Funcionario funcionario)
        {
            _context.Funcionarios.Update(funcionario);
            await _context.SaveChangesAsync(); 
        }


        public async Task<Funcionario> OterPorIdAsync(int Id)
        {
            return await _context.Funcionarios.FindAsync(Id);
        }

        public async Task<IEnumerable<Funcionario>> ObterTodosAsync()
        {
            return await _context.Funcionarios.ToListAsync();
        }

       
    }
}
