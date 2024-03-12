﻿using Domain.Core.Interfaces.Services;
using EleicaoCipa.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Domain.Services.Services;

public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase where TEntity : class
{
    private readonly IRepositoryBase<TEntity> _repository;

    public ServiceBase(IRepositoryBase<TEntity> repository)
    {
        _repository = repository;
    }
    public virtual void Post(TEntity entity)
    {
        _repository.Post(entity);
    }
    public virtual TEntity GetById(int id)
    {
        return _repository.GetById(id);
    }
    public virtual IEnumerable<TEntity> GetAll()
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

    //public virtual void Dispose()
    //{
    //    _repository.Dispose();
    //}
}
