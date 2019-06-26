using Teste.Superdigital.Domain.Contracts.Services.Base;
using Teste.Superdigital.Domain.Models;

namespace Teste.Superdigital.Domain.Contracts.Services
{
    public interface IContaCorrenteService : IBaseService<ContaCorrente>
    {
        ContaCorrente ObterPorNumero(int numero);
        void Creditar(ContaCorrente contaCorrente, double valor);
        void Debitar(ContaCorrente contaCorrente, double valor);
    }
}