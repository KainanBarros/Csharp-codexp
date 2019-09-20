using System;

namespace Numero5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());
            int result = numero*3;

            Console.WriteLine($"resutado é:{result}");



        }
    }
}
