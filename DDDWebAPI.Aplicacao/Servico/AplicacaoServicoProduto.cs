using DDDWebAPI.Aplicacao.DTO.DTO;
using DDDWebAPI.Aplicacao.Interfaces;
using DDDWebAPI.Dominio.Core.Interfaces.Servicos;
using DDDWebAPI.Infraestrutura.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace DDDWebAPI.Aplicacao.Servico
{
    public class AplicacaoServicoProduto : System.IDisposable, IAplicacaoServicoProduto
    {
        private readonly IServicoProduto _servicoProduto;
        private readonly IMapperProduto _mapperProduto;

        public AplicacaoServicoProduto(IServicoProduto ServicoProduto
                                         , IMapperProduto MapperProduto)
        {
            _servicoProduto = ServicoProduto;
            _mapperProduto = MapperProduto;
        }

        public void Add(ProdutoDTO obj)
        {
            var objProduto = _mapperProduto.MapperToEntity(obj);
            _servicoProduto.Add(objProduto);
        }

        public void Dispose()
        {
            _servicoProduto.Dispose();
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var objProdutos = _servicoProduto.GetAll();
            return _mapperProduto.MapperListProdutos(objProdutos);
        }

        public ProdutoDTO GetById(int id)
        {
            var objProduto = _servicoProduto.GetById(id);
            return _mapperProduto.MapperToDTO(objProduto);
        }

        public void Remove(ProdutoDTO obj)
        {
            var objProduto = _mapperProduto.MapperToEntity(obj);
            _servicoProduto.Remove(objProduto);
        }

        public void Update(ProdutoDTO obj)
        {
            var objProduto = _mapperProduto.MapperToEntity(obj);
            _servicoProduto.Update(objProduto);
        }

    }
}