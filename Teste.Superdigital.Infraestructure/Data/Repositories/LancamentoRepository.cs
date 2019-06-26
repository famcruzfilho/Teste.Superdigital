using Teste.Superdigital.Domain.Contracts.Repositories;
using Teste.Superdigital.Domain.Models;
using Teste.Superdigital.Infraestructure.Data.Context;
using Teste.Superdigital.Infraestructure.Data.Repositories.Base;

namespace Teste.Superdigital.Infraestructure.Data.Repositories
{
    public class LancamentoRepository : BaseRepository<Lancamento>, ILancamentoRepository
    {
        private readonly DataContext _context;

        public LancamentoRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}