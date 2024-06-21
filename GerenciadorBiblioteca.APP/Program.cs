// See https://aka.ms/new-console-template for more information

using GerenciadorBiblioteca.Domain.Entidades;


Livro livro = new Livro();
Console.WriteLine(livro.ResumoLivro());

MembroBiblioteca membro = new MembroBiblioteca();
membro.Nome = "Nome do membro";

Funcionario funcionario = new Funcionario();
Console.WriteLine(funcionario.RegistrarFuncionario());

Administrador admin = new Administrador();
// sem acesso a entidade Administrador
