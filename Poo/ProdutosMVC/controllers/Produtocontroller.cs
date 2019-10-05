using System;
using System.Collections.Generic;
using ProdutosMVC.Models;

namespace ProdutosMVC.controllers
{
    public class Produtocontroller
    {
        List<AtributosProdutosModel> listaProduto = new List<AtributosProdutosModel>();

        public void CadastroProduto (){
           

            System.Console.WriteLine("Digite o Nome do Produto:");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Qual é a Categoria");
            string categoria = Console.ReadLine();

            System.Console.WriteLine("Insira o peso:");
            double peso = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite o Valor:");
            double preco = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Quantidade em Estoque:");
            int estoque = int.Parse(Console.ReadLine());

            AtributosProdutosModel produto = new AtributosProdutosModel();

            produto.Id = listaProduto.Count + 1;
            produto.Nome = nome;
            produto.Categoria = categoria;
            produto.Preço = preco;
            produto.Peso = peso;
            produto.QemEstoque = estoque;
            produto.DataCriacao = DateTime.Now;

            listaProduto.Add(produto);
        }//Fim Função Criar

        public void ListarProduto()
        {
            foreach(var item in listaProduto)
            {
                System.Console.WriteLine("-----------------------------------------");
                System.Console.WriteLine($"Produto: {item.Nome}");
                System.Console.WriteLine($"Id: {item.Id}");
                System.Console.WriteLine($"Preço: R${item.Preço}Reais");
                System.Console.WriteLine($"Peso: {item.Peso}Kg");
                System.Console.WriteLine($"Em Estoque: {item.QemEstoque}");
                System.Console.WriteLine($"Data de Criação {item.DataCriacao}");
                System.Console.WriteLine("-----------------------------------------");
            }//Fim Foreach
        }//Fim Função Listar

        public double Soma()
        {
            int totales = 0;
            double total = 0;
            double resultado = 0;
            foreach (var item in listaProduto)
            {
                total = item.QemEstoque*item.Preço;
                totales += item.QemEstoque;
                resultado+=total;
            }
                System.Console.WriteLine($"total de produto em estoque: {totales} produtos");
                System.Console.WriteLine($"Valor total do estoque: RS{resultado}Reais");
            return resultado;
        }
    }
}