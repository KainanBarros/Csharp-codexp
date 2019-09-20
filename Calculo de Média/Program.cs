using System;

namespace Calculo_de_Média
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Média");
            int n1;
            int n2;
            int n3;

            Console.WriteLine("digite o primeiro nota");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            n2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a terceira nota");
            n3 = int.Parse(Console.ReadLine());
        
        float media = (n1+n2+n3);
        float resultado = media/3;
        Console.WriteLine($"Sua nota é: {resultado}");
        
        if(resultado>5){
            Console.WriteLine("Você foi Aprovado");
        }  
        else {Console.WriteLine("Você foi Reprovado");
        }
        
            
        
            
        }
        }
    }

