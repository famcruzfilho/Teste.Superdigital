using System;
using System.Threading.Tasks;

namespace Teste.Superdigital.Domain.Contracts.Repositories.UnityOfWork
{
    public interface IUnityOfWork : IDisposable
    {
        Task Commit();
        void BeginTransaction();
        void SaveChanges();
        void Rollback();
    }
}