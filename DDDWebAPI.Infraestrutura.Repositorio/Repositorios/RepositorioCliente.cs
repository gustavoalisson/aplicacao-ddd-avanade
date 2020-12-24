using DDDWebAPI.Dominio.Core.Interfaces.Repositorios;
using DDDWebAPI.Dominio.Models;
using DDDWebAPI.Infraestrutura.Data;
using DDDWebAPI.Infraestrutura.Repositorio.Repositorios;

namespace DDDWebAPI.Infrastruture.Repository.Repositorys
{
    public class RepositorioCliente : RepositorioBase<Cliente>, IRepositorioCliente
    {
        private readonly SqlContext _context;
        public RepositorioCliente(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}