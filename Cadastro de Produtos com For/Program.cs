using System;

namespace Cadastro_de_Produtos_com_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Produtos com For");

            string [] produtoNome = new string [3];
            double [] produtoPreco = new double [3];

            for(int i=0; i <3 ; i++)
            {
                Console .WriteLine($"Digite o nome do {i+1}° produto");
                produtoNome[i] = Console.ReadLine();
                Console.WriteLine("Digite o Preço");
                produtoPreco[i] = double.Parse(Console.ReadLine()); //CameCase          
            }//fim do for!!!!

            //Para cada produto em produtoNome 
            foreach (var item in produtoNome)
            {
                Console.WriteLine($"Produto: {item}");
            }//Fim do foreach
            for(int i = 0; i <3; i++){
                // No for eu consigo acessa quantos arrays forem necessários
                Console.WriteLine($"Produto: {produtoNome[i]} preço: {produtoPreco[i]}");
            }//Fim do for
            
        }
    }
}
