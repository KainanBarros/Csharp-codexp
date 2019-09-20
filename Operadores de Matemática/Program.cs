using System;

namespace Operadores_de_Matemática
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabela de contas");
            
            Console.WriteLine("Digite o Primeiro Número:");
            float n1 = float.Parse(Console.ReadLine());

             Console.WriteLine("Digite o Segundo Número:");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("( a ) - Soma de 2 número.");
            Console.WriteLine("( b ) - Subtração do primeiro pelo segundo.");
            Console.WriteLine("( c ) - Subtração do segundo pelo primeiro.");
            Console.WriteLine("( d ) - Multiplição dos dois números.");
            Console.WriteLine("( e ) - Divisão do primeiro pelo segundo.");
            Console.WriteLine("( f ) - Divisão do segundo número pelo primeiro");
            Console.WriteLine("-----------------------------------------------------");
            
            string resposta = Console.ReadLine();

            switch(resposta){
                case "a": 
                float result = n1+n2;
                Console.WriteLine($"A soma dos números {n1}+{n2}={result}");
                break;

                 case "b": 
                 float result2 = n1-n2;
                 Console.WriteLine($"A subtração dos números {n1}-{n2}={result2}");
                 break;
            
                 case "c": 
                 float result3 = n2-n1;
                 Console.WriteLine($"A Subtração dos números {n2}-{n1}={result3}");
                 break;

                  case "d": 
                 float result4 = n1*n2;
                 Console.WriteLine($"A Multiplicação dos números {n1}x{n2}={result4}");
                 break;

                  case "e": 
                 float result5 = n1/n2;
                 Console.WriteLine($"A Divisão dos números {n1}/{n2}= {result5}");
                 break;

                  case "f": 
                 float result6 = n2/n1;
                 Console.WriteLine($"A Divisão dos números {n2}/{n1}= {result6}");
                 break;
                 
                 default:
                 Console.WriteLine("Digite uma letra de a - f");
                 break;

            }

        }
    }
}
