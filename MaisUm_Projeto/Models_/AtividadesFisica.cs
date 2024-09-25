using System;
using System.ComponentModel.DataAnnotations;

namespace MaisUm_Projeto.Models_
{
    public class AtividadesFisica
    {
        [Key]
        public int AtividadeId { get; set; }
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public int DuracaoMinutos { get; set; }
        public String Data { get; set; }

        public Usuarios Usuario { get; set; }
    }
}