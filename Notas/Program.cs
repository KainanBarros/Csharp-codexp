using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora nota de aluno");//Mostra o texto
            Console.WriteLine("Digite o seu nome");//Mostra o texto
            string nome = Console.ReadLine();//Recebe texto

            Console.WriteLine("Digite a 1° nota");//Mostra o texto
            float v1 = float.Parse(Console.ReadLine());//Recebe o valor
            
            Console.WriteLine("Calcule a 2° nota do aluno");//Mostra o texto
            float v2 = float.Parse(Console.ReadLine());//Recebe o valor

            Console.WriteLine("Digite a 3° nota do aluno");//Mostra o texto
            float v3 = float.Parse(Console.ReadLine());//Recebe o valor

            Console.WriteLine("Digite a 4° nota do aluno");//Mostra o texto
            float v4 = float.Parse(Console.ReadLine());//Recebe o valor

            float result = (v1+v2+v3+v4)/4;

            Console.WriteLine($"{nome} sua nota é {result} ");

            if (result>=7.0){Console.WriteLine("Você foi Aprovado.");
            }
            else {Console.WriteLine("Você foi Reprovado");
            }
        }
    }
}
