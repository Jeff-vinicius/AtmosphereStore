﻿using Atmosphere.Core.Communication;
using Atmosphere.WebApp.MVC.Models;
using System;
using System.Threading.Tasks;

namespace Atmosphere.WebApp.MVC.Services
{
    public interface ICarrinhoService
    {
        Task<CarrinhoViewModel> ObterCarrinho();
        Task<ResponseResult> AdicionarItemCarrinho(ItemProdutoViewModel produto);
        Task<ResponseResult> AtualizarItemCarrinho(Guid produtoId, ItemProdutoViewModel produto);
        Task<ResponseResult> RemoverItemCarrinho(Guid produtoId);
    }
}
