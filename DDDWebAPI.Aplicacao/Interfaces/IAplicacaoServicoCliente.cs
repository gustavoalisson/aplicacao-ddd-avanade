using DDDWebAPI.Aplicacao.DTO.DTO;
using System.Collections.Generic;


namespace DDDWebAPI.Aplicacao.Interfaces
{
    public interface IAplicacaoServicoCliente
    {
        void Add(ClienteDTO obj);

        ClienteDTO GetById(int id);

        IEnumerable<ClienteDTO> GetAll();

        void Update(ClienteDTO obj);

        void Remove(ClienteDTO obj);

        void Dispose();
    }
}
