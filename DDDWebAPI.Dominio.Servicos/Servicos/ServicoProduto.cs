using DDDWebAPI.Dominio.Core.Interfaces.Repositorios;
using DDDWebAPI.Dominio.Core.Interfaces.Servicos;
using DDDWebAPI.Dominio.Models;


namespace DDDWebAPI.Dominio.Servicos.Servicos
{
    public class ServicoProduto : ServicoBase<Produto>, IServicoProduto
    {
        private readonly IRepositorioProduto _repositorioProduto;
        public ServicoProduto(IRepositorioProduto RepositorioProduto)
         : base(RepositorioProduto)
        {
            _repositorioProduto = RepositorioProduto;
        }
    }
}
