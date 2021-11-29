﻿using Atmosphere.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Atmosphere.Catalogo.API.Models
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto> ObterPorId(Guid id);

        void Adcionar(Produto produto);
        void Atualizar(Produto produto);
    }
}
