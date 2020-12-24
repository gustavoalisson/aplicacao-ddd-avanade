﻿using System;


namespace DDDWebAPI.Dominio.Models
{
    //Entidade Cliente de herdando da classe Base
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set;}
        public bool Ativo { get; set; }
    }
}
