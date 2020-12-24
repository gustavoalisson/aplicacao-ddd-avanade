using DDDWebAPI.Aplicacao.DTO.DTO;
using DDDWebAPI.Aplicacao.Interfaces;
using DDDWebAPI.Dominio.Core.Interfaces.Servicos;
using DDDWebAPI.Infraestrutura.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace DDDWebAPI.Aplicacao.Servico
{
    public class AplicacaoServicoCliente : IAplicacaoServicoCliente
    {
        private readonly IServicoCliente _servicoCliente;
        private readonly IMapperCliente _mapperCliente;

        public AplicacaoServicoCliente(IServicoCliente ServicoCliente
                                                 , IMapperCliente MapperCliente)

        {
            _servicoCliente = ServicoCliente;
            _mapperCliente = MapperCliente;
        }


        public void Add(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _servicoCliente.Add(objCliente);
        }

        public void Dispose()
        {
            _servicoCliente.Dispose();
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var objProdutos = _servicoCliente.GetAll();
            return _mapperCliente.MapperListClientes(objProdutos);
        }

        public ClienteDTO GetById(int id)
        {
            var objcliente = _servicoCliente.GetById(id);
            return _mapperCliente.MapperToDTO(objcliente);
        }

        public void Remove(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _servicoCliente.Remove(objCliente);
        }

        public void Update(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _servicoCliente.Update(objCliente);
        }
    }
}