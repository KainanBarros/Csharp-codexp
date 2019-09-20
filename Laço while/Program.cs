using System;

namespace Laço_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laço de Repedição While");

            Console.WriteLine("Digite o número Inicial");
            int contador = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor limite");
            int limite = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------");

            while(contador <= limite)
            {
                Console.WriteLine(contador);
                contador = contador + 1;//encrementar
            }
        }
    }
}
