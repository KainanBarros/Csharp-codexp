using System;

namespace Validacao_com_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validacao com while");
            string nome;

            do{
                Console.WriteLine("Digite seu nome");
                nome = Console.ReadLine();
            }while(nome.Length <= 1);

            string senha;
            do{
                Console.WriteLine("Digite sua senha");
                senha = Console.ReadLine();
            }while(senha.Length <= 8);
        }
    }
}
