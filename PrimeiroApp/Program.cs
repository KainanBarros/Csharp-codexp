using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
        // Aqui é onde iremos inserir o código
        
        Console.WriteLine("Soma de dois números");

        int n1;
        int n2;
        int result;

        Console.WriteLine("Digite o primeiro número");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo Número");
        n2 = int.Parse(Console.ReadLine());
        
        result= n1+n2;

        Console.WriteLine($"Seu resultado é:{result}");
        
        }
    }
}
