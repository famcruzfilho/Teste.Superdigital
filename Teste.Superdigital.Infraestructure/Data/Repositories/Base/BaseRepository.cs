using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Teste.Superdigital.Domain.Contracts.Repositories.Base;
using Teste.Superdigital.Infraestructure.Data.Context;

namespace Teste.Superdigital.Infraestructure.Data.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public void Criar(TEntity TEntity)
        {
            _context.Set<TEntity>().Add(TEntity);
        }

        public void Deletar(TEntity TEntity)
        {
            _context.Set<TEntity>().Remove(TEntity);
        }

        public void DeletarPorId(int id)
        {
            var data = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(data);
        }

        IEnumerable<TEntity> IBaseRepository<TEntity>.ObterTodos()
        {
            return _context.Set<TEntity>().ToList();
        }

        TEntity IBaseRepository<TEntity>.ObterPorId(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Atualizar(TEntity TEntity)
        {
            _context.Set<TEntity>().Attach(TEntity);
            _context.Entry(TEntity).State = EntityState.Modified;
        }
    }
}