using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public String Data { get; set; }

        public Usuarios Usuario { get; set; }
    }
}