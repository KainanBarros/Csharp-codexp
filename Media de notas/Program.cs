using System;

namespace Media_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media de notas");
            Console.WriteLine("---------------------------------------");

            int [] nota1 = new int [10];
            int [] nota2 = new int [10];
            float total = 0;
            int contador = 0;

            while(contador < 10){
                Console.WriteLine("Digite a 1° nota:");
                nota1 [contador] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 2° nota:");
                nota2 [contador] = int.Parse(Console.ReadLine());
                contador++;
            }
            contador = 0;
            while(contador < 10){
                int somadoria = nota1 [contador] + nota2 [contador];
                float resultado = somadoria/2;
                total =+ resultado;
                contador++;
            if(resultado >= 7){
                Console.WriteLine($"Você foi Aprovado.");
            }
            else{
                Console.WriteLine("Você foi reprovado.");
            }
            }

            Console.WriteLine($" {total/10}");
        }
    }
}
