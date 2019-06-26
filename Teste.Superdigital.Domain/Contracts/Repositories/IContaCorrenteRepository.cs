using Teste.Superdigital.Domain.Contracts.Repositories.Base;
using Teste.Superdigital.Domain.Models;

namespace Teste.Superdigital.Domain.Contracts.Repositories
{
    public interface IContaCorrenteRepository : IBaseRepository<ContaCorrente>
    {
        ContaCorrente ObterPorNumero(int numero);
    }
}