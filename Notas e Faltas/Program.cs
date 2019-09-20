using System;

namespace Notas_e_Faltas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("APP Cálculo de Notas e Faltas");
            
            Console.WriteLine("Bem vindo a escola SENAI de Informática");
            
            Console.WriteLine("Digite a primeira nota");
            int nota1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a segunda nota");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de Faltas");
            int faltas = int.Parse(Console.ReadLine());

                double resultado = nota1+nota2/2;
            
            if(resultado >=50 && faltas<= 30){
                Console.WriteLine($"Você foi Aprovado.");
            }
            else{
                Console.WriteLine($"Você foi reprovado");
            }
            
            
        }
    }
}
