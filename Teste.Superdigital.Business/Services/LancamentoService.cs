using Teste.Superdigital.Business.Services.Base;
using Teste.Superdigital.Domain.Contracts.Repositories;
using Teste.Superdigital.Domain.Contracts.Services;
using Teste.Superdigital.Domain.Models;

namespace Teste.Superdigital.Business.Services
{
    public class LancamentoService : BaseService<Lancamento>, ILancamentoService
    {
        private readonly ILancamentoRepository _lancamentoRepository;

        public LancamentoService(ILancamentoRepository lancamentoRepository) : base(lancamentoRepository)
        {
            _lancamentoRepository = lancamentoRepository;
        }
    }
}