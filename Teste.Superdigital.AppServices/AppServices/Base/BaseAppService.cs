using System.Collections.Generic;
using Teste.Superdigital.Domain.Contracts.AppServices.Base;
using Teste.Superdigital.Domain.Contracts.Services.Base;

namespace Teste.Superdigital.AppServices.AppServices.Base
{
    public class BaseAppService<TEntity> : IBaseAppService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> _service;

        public BaseAppService(IBaseService<TEntity> service)
        {
            _service = service;
        }

        public void Atualizar(TEntity TEntity)
        {
            _service.Atualizar(TEntity);
        }

        public void Criar(TEntity TEntity)
        {
            _service.Criar(TEntity);
        }

        public void Deletar(TEntity TEntity)
        {
            _service.Deletar(TEntity);
        }

        public void DeletarPorId(int id)
        {
            _service.DeletarPorId(id);
        }

        public TEntity ObterPorId(int id)
        {
            return _service.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _service.ObterTodos();
        }
    }
}