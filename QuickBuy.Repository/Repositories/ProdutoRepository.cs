using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using QuickBuy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
