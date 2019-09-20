using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você tem direito de meia entrada?");

            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if(idade <18 || idade >=60){
                Console.WriteLine("Você tem direito a meia entrada.");               
            }
            else{
                Console.WriteLine("Você não tem direito a meia entrada");
            }
        }
    }
}
