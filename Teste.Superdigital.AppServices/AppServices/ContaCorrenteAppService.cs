using Teste.Superdigital.AppServices.AppServices.Base;
using Teste.Superdigital.Domain.Contracts.AppServices;
using Teste.Superdigital.Domain.Contracts.Services;
using Teste.Superdigital.Domain.Models;

namespace Teste.Superdigital.AppServices.AppServices
{
    public class ContaCorrenteAppService : BaseAppService<ContaCorrente>, IContaCorrenteAppService
    {
        private readonly IContaCorrenteService _contaCorrenteService;

        public ContaCorrenteAppService(IContaCorrenteService contaCorrenteService) : base(contaCorrenteService)
        {
            _contaCorrenteService = contaCorrenteService;
        }

        public ContaCorrente ObterPorNumero(int numero)
        {
            return _contaCorrenteService.ObterPorNumero(numero);
        }

        public void Creditar(ContaCorrente contaCorrente, double valor)
        {
            _contaCorrenteService.Creditar(contaCorrente, valor);
        }

        public void Debitar(ContaCorrente contaCorrente, double valor)
        {
            _contaCorrenteService.Debitar(contaCorrente, valor);
        }
    }
}