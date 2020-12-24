using DDDWebAPI.Dominio.Core.Interfaces.Repositorios;
using DDDWebAPI.Dominio.Models;
using DDDWebAPI.Infraestrutura.Data;
using DDDWebAPI.Infraestrutura.Repositorio.Repositorios;

namespace DDDWebAPI.Infrastruture.Repository.Repositorys
{
    public class RepositorioProduto : RepositorioBase<Produto>, IRepositorioProduto
    {

        private readonly SqlContext _context;
        public RepositorioProduto(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

    }
}