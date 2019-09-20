using System;

namespace Tabela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabela");

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu salário:");
            double salario = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite um Código de 1 a 5:");
            string resultado = Console.ReadLine();
            
            switch(resultado){
                case "1":
                double n1 = 0.5*salario;
                double result1 = n1+salario;

                Console.WriteLine($"Olá {nome} você tem o cargo de Escriturário,o seu salário é {salario} reais , com o reajuste de 50% você recebe {result1} reais. ");
                break;
                
                case "2":
                double n2 = 0.35*salario;
                double result2 = n2+salario;

                Console.WriteLine($"Olá {nome} você tem o cargo de Secretário,o seu salário é {salario} reais , com o reajuste de 35% você recebe {result2} reais. ");
                break;

                case "3":
                double n3 = 0.2*salario;
                double result3 = n3+salario;

                Console.WriteLine($"Olá {nome} você tem o cargo de Caixa,o seu salário é {salario} reais , com o reajuste de 20% você recebe {result3} reais. ");
                break;

                case "4":
                double n4 = 0.1*salario;
                double result4 = n4+salario;

                Console.WriteLine($"Olá {nome} você tem o cargo de Gerente, o seu salário é de {salario} reais , com reajuste de 10% você recebe {result4} reais. ");
                break;

                case "5":
                Console.WriteLine($"Olá {nome} você tem o cargo de Diretor e não tem percentual de aumento ");
                break;

                default:
                Console.WriteLine("Digite um número de 1 a 5");
                break;
            }
            
        }
    }
}
