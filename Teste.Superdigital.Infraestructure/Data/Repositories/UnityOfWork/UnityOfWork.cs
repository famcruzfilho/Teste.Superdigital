using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;
using Teste.Superdigital.Domain.Contracts.Repositories.UnityOfWork;
using Teste.Superdigital.Infraestructure.Data.Context;

namespace Teste.Superdigital.Infraestructure.Data.Repositories.UnityOfWork
{
    public class UnityOfWork : IUnityOfWork
    {
        public readonly DataContext _context;

        private IDbContextTransaction _contextTransaction;
        public ContaCorrenteRepository _contaCorrenteRepository { get; private set; }
        public LancamentoRepository _lancamentoRepository { get; private set; }

        public UnityOfWork(DataContext context)
        {
            _context = context;
            _contaCorrenteRepository = new ContaCorrenteRepository(_context);
            _lancamentoRepository = new LancamentoRepository(_context);
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void BeginTransaction() => _contextTransaction = _context.Database.BeginTransaction();

        public void SaveChanges() => _context.SaveChanges();

        public void Rollback() => _contextTransaction.Rollback();
    }
}