using Autofac;
using DDDWebAPI.Aplicacao.Interfaces;
using DDDWebAPI.Aplicacao.Servico;
using DDDWebAPI.Dominio.Core.Interfaces.Repositorios;
using DDDWebAPI.Dominio.Core.Interfaces.Servicos;
using DDDWebAPI.Dominio.Servicos.Servicos;
using DDDWebAPI.Infraestrutura.CrossCutting.Adapter.Interfaces;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Map;
using DDDWebAPI.Infrastruture.Repository.Repositorys;

namespace DDDWebAPI.Infraestrutura.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<AplicacaoServicoCliente>().As<IAplicacaoServicoCliente>();
            builder.RegisterType<AplicacaoServicoProduto>().As<IAplicacaoServicoProduto>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServicoCliente>().As<IServicoCliente>();
            builder.RegisterType<IServicoProduto>().As<IServicoProduto>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositorioCliente>().As<IRepositorioCliente>();
            builder.RegisterType<RepositorioProduto>().As<IRepositorioProduto>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            #endregion

            #endregion

        }
    }
}