using DDDWebAPI.Dominio.Core.Interfaces.Repositorios;
using DDDWebAPI.Infraestrutura.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDDWebAPI.Infraestrutura.Repositorio.Repositorios
{
    public abstract class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _context;

        public RepositorioBase(SqlContext Context)
        {
            _context = Context;
        }

        public virtual void Add(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual void Update(TEntity obj)
        {

            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public virtual void Remove(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public virtual void Dispose()
        {
            _context.Dispose();
        }


    }
}