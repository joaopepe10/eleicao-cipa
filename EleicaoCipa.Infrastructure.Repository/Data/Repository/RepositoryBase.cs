using EleicaoCipa.Domain.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Infraestrutura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleicaoCipa.Infrastructure.Repository.Data.Repository;

public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
{
    private readonly EleicaoContext _context;

    public RepositoryBase(EleicaoContext context)
    {
        _context = context;
    }

    public TEntity Post(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public TEntity? GetById(int id)
    {
        return _context.Set<TEntity>().FirstOrDefault(entity => entity.Equals(id));
    }

    public virtual IEnumerable<TEntity>? GetAll()
    {
        return _context.Set<TEntity>().ToList();
    }

    public TEntity Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        _context.SaveChanges();
        return entity;
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        _context.SaveChanges();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
