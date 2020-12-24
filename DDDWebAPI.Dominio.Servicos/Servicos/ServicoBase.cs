
using DDDWebAPI.Dominio.Core.Interfaces.Repositorios;
using DDDWebAPI.Dominio.Core.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace DDDWebAPI.Dominio.Servicos.Servicos
{
    // essa classe contem metodos genericos
    public abstract class ServicoBase<TEntity> : IDisposable, IServicoBase<TEntity> where TEntity : class
    {
        private readonly IRepositorioBase<TEntity> _repositorio;

        public ServicoBase(IRepositorioBase<TEntity> Repositorio)
        {
            _repositorio = Repositorio;
        }
        public virtual void Add(TEntity obj)
        {
            _repositorio.Add(obj);
        }
        public virtual TEntity GetById(int id)
        {
            return _repositorio.GetById(id);
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repositorio.GetAll();
        }
        public virtual void Update(TEntity obj)
        {
            _repositorio.Update(obj);
        }
        public virtual void Remove(TEntity obj)
        {
            _repositorio.Remove(obj);
        }

        public virtual void Dispose()
        {
            _repositorio.Dispose();
        }
    }
}