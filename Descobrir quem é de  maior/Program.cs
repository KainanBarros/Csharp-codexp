using System;

namespace Descobrir_quem_é_de__maior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maiores de idade.");

            int [] idade = new int [10];
            int maior = 0;
            int menor = 0;
            int contador = 0;

            while(contador <10){
                Console.WriteLine("Digite sua idade");
                idade  [contador] = int.Parse(Console.ReadLine());
                
                if(idade[contador] >=18){
                    maior++;
                }
                else{
                    menor++;
                }
                contador++;
            }

                System.Console.WriteLine($"Tem {maior} maiores de idade");
                System.Console.WriteLine($"Tem {menor} menores de idade");
        }
    }
}
