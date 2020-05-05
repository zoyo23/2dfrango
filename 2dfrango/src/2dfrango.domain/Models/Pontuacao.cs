namespace _2dfrango.domain.Models
{
    public class Pontuacao
    {
        public string Email { get; set; }
        public int Moedas { get; set; }
        public int Diamantes { get; set; }

        public virtual Autenticacao Autenticacao { get; set; }
    }
}
