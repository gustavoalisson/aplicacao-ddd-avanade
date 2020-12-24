using DDDWebAPI.Aplicacao.DTO.DTO;
using DDDWebAPI.Dominio.Models;
using System.Collections.Generic;

namespace DDDWebAPI.Infraestrutura.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCliente
    {
        #region Mappers

        Cliente MapperToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);

        ClienteDTO MapperToDTO(Cliente Cliente);

        #endregion

    }
}