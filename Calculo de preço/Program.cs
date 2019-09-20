using System;

namespace Calculo_de_preço
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de preço");
            Console.WriteLine("Digite o valor");
            int valor = int.Parse(Console.ReadLine());
            int percentual = int.Parse(Console.ReadLine());
            int result = ((valor*10)/100);
            int total =result+valor;

            Console.WriteLine($"O valor da mercadoria é {valor} reais com acrescimo de {result} reais, total de {total} reais. "); 
        }
    }
}
