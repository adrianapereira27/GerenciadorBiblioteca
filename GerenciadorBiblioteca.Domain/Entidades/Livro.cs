namespace GerenciadorBiblioteca.Domain.Entidades
{
    public class Livro
    {
        public string Titulo { get; set; }
        protected string Author { get; set; }
        internal string ISBN { get; set; }

        public string ResumoLivro()
        {
            return "Resumo do Livro.";
        }
    }
}
