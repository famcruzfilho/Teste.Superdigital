using System.Collections.Generic;

namespace Teste.Superdigital.Domain.Contracts.AppServices.Base
{
    public interface IBaseAppService<TEntity> where TEntity : class
    {
        void Criar(TEntity TEntity);
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(int id);
        void Atualizar(TEntity TEntity);
        void Deletar(TEntity TEntity);
        void DeletarPorId(int id);
    }
}