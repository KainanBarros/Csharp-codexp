using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de idade");

            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            
            int meses = idade*12;
            int dias = 365*idade;
            int horas = (24*365)*idade;
            int minutos = ((60*24)*365)*idade;
            int seg = (((60*60)*24)*365)*idade;
            Console.WriteLine($"Sua Idade é {meses} meses; {dias} dias; {horas} horas; {minutos} minutos; {seg} segundos.");


        }
    }
}
