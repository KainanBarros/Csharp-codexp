using System;

namespace Salario_Ajustado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reajuste de Sálario");

            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sálario");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Óla "+nome);

            
            if(salario<990){
            double porcentagem = 0.3*salario;
            double result = porcentagem+salario;
                Console.WriteLine("Reajuste aprovado");
                Console.WriteLine($"{nome} Seu salário foi reajustado para {result} reais. ");
            }
            else{Console.WriteLine("reajuste foi reprovado");
            Console.WriteLine($"{nome} Seu salário é de {salario} reais,não cumpre o requisito. ");
            }



        }
    }
}
