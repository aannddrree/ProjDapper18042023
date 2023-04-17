// See https://aka.ms/new-console-template for more information
using Controllers;
using Models;

Console.WriteLine("Projeto Biblioteca - Cadastro de Livros");


Book book = new()
{
    Name = "Era uma vez",
    NumberOfPages = 100
};

if (new BookController().Insert(book))
    Console.WriteLine("Registro Inserido!");
else
    Console.WriteLine("Erro ao inserir registro!");


new BookController().FindAll().ForEach(x => Console.WriteLine(x));

