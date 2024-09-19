using System.ComponentModel.DataAnnotations;

namespace MaisUm_Projeto.Models_
{
    public class Progresso
    {
        [Key]
        public int ProgressoId { get; set; }
        public int UsuarioId { get; set; }
        public float Peso { get; set; }
        public string Data { get; set; }
        public string Observacoes { get; set; }

        public Usuario Usuario { get; set; }
    }
}