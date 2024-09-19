using System;
using System.ComponentModel.DataAnnotations;

namespace MaisUm_Projeto.Models_
{
    public class AtividadeFisica
    {
        [Key]
        public int AtividadeId { get; set; }
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public int DuracaoMinutos { get; set; }
        public DateTime Data { get; set; }

        public Usuario Usuario { get; set; }
    }
}