using System;
using VigadoresMVC.Controllers;

namespace VigadoresMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            VingadoreController vG = new VingadoreController();
            Console.WriteLine("Bem Vindo ao Vingadores");
            int escolha;
            do{
                System.Console.WriteLine("Ecolha um Personagem");
                System.Console.WriteLine("1 - Capitão América");
                System.Console.WriteLine("2 - Homem de Ferro");
                System.Console.WriteLine("0 - Sair do Game");
                escolha = int.Parse(Console.ReadLine());

                switch(escolha)
                
                {
                    case 1:
                    //capitão américa
                    vG.Capitaoamerica();
                    break;
                    
                    case 2:
                    //homem de ferro
                    vG.HomemDeFerro();
                    break;
                    case 0:
                    //Sair
                    System.Console.WriteLine("Finalizando o Sistema");
                    break;
                    default:
                    System.Console.WriteLine("opção inválida");
                    break;
                }

            }while(escolha!=0);
        }
    }
}
