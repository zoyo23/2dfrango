namespace _2dfrango.domain.Models
{
    public class Autenticacao
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        public virtual Pontuacao Pontuacao { get; set; }
    }
}
