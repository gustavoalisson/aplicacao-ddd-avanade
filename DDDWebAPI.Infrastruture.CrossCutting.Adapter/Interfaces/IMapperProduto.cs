using DDDWebAPI.Aplicacao.DTO.DTO;
using DDDWebAPI.Dominio.Models;
using System.Collections.Generic;

namespace DDDWebAPI.Infraestrutura.CrossCutting.Adapter.Interfaces
{
    public interface IMapperProduto
    {
        #region Interfaces Mappers
        Produto MapperToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> clientes);

        ProdutoDTO MapperToDTO(Produto produto);

        #endregion

    }
}