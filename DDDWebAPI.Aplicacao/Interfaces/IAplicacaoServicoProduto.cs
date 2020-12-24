using DDDWebAPI.Aplicacao.DTO.DTO;
using System.Collections.Generic;


namespace DDDWebAPI.Aplicacao.Servico
{
    public interface IAplicacaoServicoProduto
    {
        void Add(ProdutoDTO obj);

        ProdutoDTO GetById(int id);

        IEnumerable<ProdutoDTO> GetAll();

        void Update(ProdutoDTO obj);

        void Remove(ProdutoDTO obj);

        void Dispose();
    }
}
