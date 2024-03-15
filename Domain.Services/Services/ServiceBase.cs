using EleicaoCipa.Domain.Nucleo.Interfaces.Repositories;

namespace EleicaoCipa.Domain.Servicos.Services;

public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
{
    private readonly IRepositoryBase<TEntity> _repository;

    public ServiceBase(IRepositoryBase<TEntity> repository)
    {
        _repository = repository;
    }
    public virtual TEntity Post(TEntity entity)
    {
        _repository.Post(entity);
        return entity;
    }
    public virtual TEntity? GetById(int id)
    {
        return _repository.GetById(id);
    }
    public virtual IEnumerable<TEntity>? GetAll()
    {
        return _repository.GetAll();
    }
    public virtual void Update(TEntity entity)
    {
        _repository.Update(entity);
    }
    public virtual void Delete(TEntity entity)
    {
        _repository.Delete(entity);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
