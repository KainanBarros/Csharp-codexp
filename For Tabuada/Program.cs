using System;

namespace For_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada com for.");
            int resultado = 0;
            int tabuada = 0;
            Console.WriteLine("Digite uma Tabuada");
                tabuada = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------");
            for(int i =0; i<=10; i++){
                resultado = tabuada * i ;
                Console.WriteLine($"{tabuada} X {i} = {resultado}");
                Console.WriteLine("------------------------------");
            }


        }
    }
}
