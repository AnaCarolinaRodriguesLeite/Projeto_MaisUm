using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaisUm_Projeto.Models_
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DataNascimento { get; set; }
        //public DateTime DataCadastro { get; set; }
    }

}