using System;
using System.Collections.Generic;
using DDDWebAPI.Aplicacao.DTO.DTO;
using DDDWebAPI.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDDD.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        private readonly IAplicacaoServicoCliente _aplicacaoServiceCliente;


        public ClientesController(IAplicacaoServicoCliente ApplicationServiceCliente)
        {
            _aplicacaoServiceCliente = ApplicationServiceCliente;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_aplicacaoServiceCliente.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_aplicacaoServiceCliente.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _aplicacaoServiceCliente.Add(clienteDTO);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _aplicacaoServiceCliente.Update(clienteDTO);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _aplicacaoServiceCliente.Remove(clienteDTO);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
