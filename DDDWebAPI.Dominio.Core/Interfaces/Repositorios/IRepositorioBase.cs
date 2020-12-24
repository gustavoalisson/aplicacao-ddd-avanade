using System;
using System.Collections.Generic;
using System.Text;

namespace DDDWebAPI.Dominio.Core.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        //interfaces implementadas
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();

    }
}
