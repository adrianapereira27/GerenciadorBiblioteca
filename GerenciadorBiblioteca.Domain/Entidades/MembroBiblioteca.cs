namespace GerenciadorBiblioteca.Domain.Entidades
{
    public class MembroBiblioteca
    {
        public string Nome { get; set; }
        private int Id { get; set; }

        internal string PegarLivroEmprestado()
        {
            return "Livro foi emprestado";
        }

        protected string ObterInformacoesSobreMembro()
        {
            return "Informações sobre o membro";
        }
    }
}
