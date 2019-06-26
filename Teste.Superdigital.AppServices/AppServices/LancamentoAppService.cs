using Teste.Superdigital.AppServices.AppServices.Base;
using Teste.Superdigital.Domain.Contracts.AppServices;
using Teste.Superdigital.Domain.Contracts.Services;
using Teste.Superdigital.Domain.Models;

namespace Teste.Superdigital.AppServices.AppServices
{
    public class LancamentoAppService : BaseAppService<Lancamento>, ILancamentoAppService
    {
        private readonly ILancamentoService _lancamentoService;

        public LancamentoAppService(ILancamentoService lancamentoService) : base(lancamentoService)
        {
            _lancamentoService = lancamentoService;
        }
    }
}