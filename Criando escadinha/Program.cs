using System;

namespace Criando_escadinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string vazia = "";

            Console.WriteLine("Informe o material");
            string material = Console.ReadLine();

            // int looop = 2;

            // while(looop > 0){

                int contadorSoma = 0;
                while(contadorSoma < 10){

                    
                    Console.WriteLine($"{vazia}");
                    vazia = vazia + material;
                    
                    contadorSoma ++;
                }

                int contador = 0;
                while(contador < 10){
                    Console.WriteLine(vazia.Substring(contador));
                    contador ++;
                }

            //     looop--;
            // }
        }
    }
}
