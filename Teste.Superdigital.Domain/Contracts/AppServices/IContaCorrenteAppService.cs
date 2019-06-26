using Teste.Superdigital.Domain.Contracts.AppServices.Base;
using Teste.Superdigital.Domain.Models;

namespace Teste.Superdigital.Domain.Contracts.AppServices
{
    public interface IContaCorrenteAppService : IBaseAppService<ContaCorrente>
    {
        ContaCorrente ObterPorNumero(int numero);
        void Creditar(ContaCorrente contaCorrente, double valor);
        void Debitar(ContaCorrente contaCorrente, double valor);
    }
}