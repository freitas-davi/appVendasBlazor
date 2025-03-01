﻿using AppVendasBlazor.Model;

namespace AppVendasBlazor.Service.Interface
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> ObterTodosAsync();
        Task<Produto> OterPorIdAsync(int Id);
        Task AdicionarAsync(Produto produto);
        Task AlterarAsync(Produto produto);
        Task ExcluirAsync(int Id);
    }
}
