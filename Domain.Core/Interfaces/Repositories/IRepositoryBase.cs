namespace EleicaoCipa.Domain.Nucleo.Interfaces.Repositories;
public interface IRepositoryBase<TEntity> where TEntity : class
{
    TEntity Post(TEntity entity);
    TEntity? GetById(int id);
    IEnumerable<TEntity>? GetAll();
    TEntity Update(TEntity entity);
    void Delete(TEntity entity);
}
