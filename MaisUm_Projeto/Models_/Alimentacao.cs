using System;
using System.ComponentModel.DataAnnotations;

namespace MaisUm_Projeto.Models_
{
    public class Alimentacao
    {
        [Key]
        public int AlimentacaoId { get; set; }
        public int UsuarioId { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public int Calorias { get; set; }
        public DateTime Data { get; set; }

        public Usuario Usuario { get; set; }
    }
}