using DDDWebAPI.Dominio.Core.Interfaces.Repositorios;
using DDDWebAPI.Dominio.Core.Interfaces.Servicos;
using DDDWebAPI.Dominio.Models;

namespace DDDWebAPI.Dominio.Servicos.Servicos
{
    public class ServicoCliente : ServicoBase<Cliente>, IServicoCliente
    {
        public readonly IRepositorioCliente _repositorioCliente;

        public ServicoCliente(IRepositorioCliente RepositorioCliente)
            : base(RepositorioCliente)
        {
            _repositorioCliente = RepositorioCliente;
        }

    }
}