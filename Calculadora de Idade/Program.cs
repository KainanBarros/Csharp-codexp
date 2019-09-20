using System;

namespace Calculadora_de_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Idade");
            Console.WriteLine("Digite o ano que você nasceu");
            int ano = int.Parse(Console.ReadLine());

          int anoatual = DateTime.Now.Year;

          int idade = anoatual-ano;

          int semana = idade*52;

          Console.WriteLine($"Você tem {idade} anos ou em semanas {semana} semanas de vida.");
        
        }
    }
}
