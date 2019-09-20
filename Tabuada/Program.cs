using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número da tabuada que deseja:");
            int num = int.Parse(Console.ReadLine());
            int contator = 0;

            while(contator<=10){
                int resultado = num*contator;
                Console.WriteLine($"{num} X {contator} = {resultado}");
                contator++;
                }        }
    }
}
