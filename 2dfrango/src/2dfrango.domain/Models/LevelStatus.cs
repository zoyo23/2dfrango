using System.Collections.Generic;

namespace _2dfrango.domain.Models
{
    public class LevelStatus
    {
        public int LevelAtual { get; set; }
        public List<Desafio> DesafiosConcluidos { get; set; } = new List<Desafio>();
        public List<Desafio> DesafiosPendentes { get; set; } = new List<Desafio>();
    }
}
