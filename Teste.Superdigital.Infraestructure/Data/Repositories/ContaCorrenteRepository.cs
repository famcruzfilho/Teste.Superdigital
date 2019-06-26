using System.Linq;
using Teste.Superdigital.Domain.Contracts.Repositories;
using Teste.Superdigital.Domain.Models;
using Teste.Superdigital.Infraestructure.Data.Context;
using Teste.Superdigital.Infraestructure.Data.Repositories.Base;

namespace Teste.Superdigital.Infraestructure.Data.Repositories
{
    public class ContaCorrenteRepository : BaseRepository<ContaCorrente>, IContaCorrenteRepository
    {
        private readonly DataContext _context;

        public ContaCorrenteRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public ContaCorrente ObterPorNumero(int numero)
        {
            var data = _context.ContasCorrentes.FirstOrDefault(x => x.Numero == numero);
            return data;
        }
    }
}