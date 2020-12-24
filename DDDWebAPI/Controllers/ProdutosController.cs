using DDDWebAPI.Aplicacao.DTO.DTO;
using DDDWebAPI.Aplicacao.Servico;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebApiDDD.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IAplicacaoServicoProduto _aplicacaoServiceProduto;

        public ProdutosController(IAplicacaoServicoProduto AplicacaoServiceProduto)
        {
            _aplicacaoServiceProduto = AplicacaoServiceProduto;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_aplicacaoServiceProduto.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_aplicacaoServiceProduto.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDTO produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();


                _aplicacaoServiceProduto.Add(produtoDTO);
                return Ok("O produto foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDTO produtoDTO)
        {

            try
            {
                if (produtoDTO == null)
                    return NotFound();

                _aplicacaoServiceProduto.Update(produtoDTO);
                return Ok("O produto foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDTO produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                _aplicacaoServiceProduto.Remove(produtoDTO);
                return Ok("O produto foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}