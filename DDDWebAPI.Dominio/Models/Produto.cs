using System;
using System.Collections.Generic;
using System.Text;

namespace DDDWebAPI.Dominio.Models
{
    // Entidade Produto herdando da classe Base
   public class Produto : Base
    {
        public string Nome { get; set; }
        public  decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }


    }
}
