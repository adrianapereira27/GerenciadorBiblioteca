namespace GerenciadorBiblioteca.Domain.Entidades
{
    public class Funcionario
    {
        protected internal int Id { get; set; }

        protected string AdicionarLivro()
        {
            return "Livro adicionado";
        }
        private protected string RemoverLivro()
        {
            return "Livro removido";
        }
        public string RegistrarFuncionario()
        {
            return "Funcionário registrado";
        }
    }
}
