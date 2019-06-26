using System.Collections.Generic;
using Teste.Superdigital.Domain.Contracts.Repositories.Base;
using Teste.Superdigital.Domain.Contracts.Services.Base;

namespace Teste.Superdigital.Business.Services.Base
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Atualizar(TEntity TEntity)
        {
            _repository.Atualizar(TEntity);
        }

        public void Criar(TEntity TEntity)
        {
            _repository.Criar(TEntity);
        }

        public void Deletar(TEntity TEntity)
        {
            _repository.Deletar(TEntity);
        }

        public void DeletarPorId(int id)
        {
            _repository.DeletarPorId(id);
        }

        public TEntity ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}