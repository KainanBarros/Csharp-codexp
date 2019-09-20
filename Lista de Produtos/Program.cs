using System;

namespace Lista_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Produtos");

            string[] produtos = new string [6];
            int contador = 0;

            while(contador <6){
                Console.WriteLine("Digite a lista de produtos");
                
                produtos[contador] = Console.ReadLine();

                contador++;
            }
                Console.WriteLine("Veja a sua lista de compras abaixo:");
            contador = 0;
            while(contador <6){
                Console.WriteLine($"{contador+1}° - {produtos[contador]}");
                contador++;
            
            }

        }
    }
}
