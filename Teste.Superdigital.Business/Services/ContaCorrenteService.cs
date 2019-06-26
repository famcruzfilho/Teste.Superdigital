using Teste.Superdigital.Business.Services.Base;
using Teste.Superdigital.Domain.Contracts.Repositories;
using Teste.Superdigital.Domain.Contracts.Services;
using Teste.Superdigital.Domain.Models;

namespace Teste.Superdigital.Business.Services
{
    public class ContaCorrenteService : BaseService<ContaCorrente>, IContaCorrenteService
    {
        private readonly IContaCorrenteRepository _contaCorrenteRepository;

        public ContaCorrenteService(IContaCorrenteRepository contaCorrenteRepository) : base(contaCorrenteRepository)
        {
            _contaCorrenteRepository = contaCorrenteRepository;
        }

        public ContaCorrente ObterPorNumero(int numero)
        {
            return _contaCorrenteRepository.ObterPorNumero(numero);
        }

        public void Creditar(ContaCorrente contaCorrente, double valor)
        {
            var contaCorrenteCompleta = ObterPorNumero(contaCorrente.Numero);
            contaCorrenteCompleta.Saldo = contaCorrenteCompleta.Saldo + valor;
            _contaCorrenteRepository.Atualizar(contaCorrenteCompleta);
        }

        public void Debitar(ContaCorrente contaCorrente, double valor)
        {
            var contaCorrenteCompleta = ObterPorNumero(contaCorrente.Numero);
            contaCorrenteCompleta.Saldo = contaCorrenteCompleta.Saldo - valor;
            _contaCorrenteRepository.Atualizar(contaCorrenteCompleta);
        }
    }
}