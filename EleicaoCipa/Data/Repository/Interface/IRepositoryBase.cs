namespace EleicaoCipa.Data.Repository.Interface;

public interface IRepositoryBase<TEntity>
{
    TEntity Post(TEntity entity);
    TEntity? GetById(int id);
    IEnumerable<TEntity>? GetAll();
    TEntity Update(TEntity entity);
}
