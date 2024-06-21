namespace GerenciadorBiblioteca.Domain.Entidades
{
    public class Administrador
    {
        private int Id { get; set; }

        internal string GerenciarBiblioteca()
        {
            return "Gerenciar Biblioteca";
        }
        protected string ObterInformacoesDetalhadas()
        {
            return "Informações obtidas";
        }

    }
}
