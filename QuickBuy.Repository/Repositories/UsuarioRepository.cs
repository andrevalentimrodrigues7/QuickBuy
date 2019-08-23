using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using QuickBuy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
