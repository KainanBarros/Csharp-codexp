using System;

namespace Criar_um_sitemas_de_email
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criar um sistema de email");
            string email;
            do{

            Console.WriteLine("Digite seu email:");
            email = Console.ReadLine();
            
            }while(!email.Contains("@") || !email.Contains("."));

        }
    }
}
