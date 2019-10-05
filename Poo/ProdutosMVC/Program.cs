using System;
using ProdutosMVC.controllers;

namespace ProdutosMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtocontroller produtoController = new Produtocontroller();
            Console.WriteLine("Olá Seja Bem-vindo");
            int opcao = 0;
            do{
                Console.WriteLine("Escolha uma opção Abaixo:");
                Console.WriteLine("1 - Cadastrar um Novo Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Calcular o Preço de todos os Produtos");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                //Cadastrar
                produtoController.CadastroProduto();
                break;

                case 2:
                //Listar Produto
                produtoController.ListarProduto();
                break;

                case 3:
                //Soma de Todos os Produtos
                produtoController.Soma();
                break;

                case 0:
                //Sair
                break;
                default:
                Console.WriteLine("Opção Invalida");
                break;
            }
            }while(opcao!=0);
        }
    }
}
