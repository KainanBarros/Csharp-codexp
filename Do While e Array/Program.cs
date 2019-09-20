using System;

namespace Do_While_e_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While com Array");

            string[] nomes = new string[3];
            int contador = 0;
            while(contador <3){

                Console.WriteLine($"Digite o {contador+1}° nome ");
                nomes [contador] = Console.ReadLine();
                contador++;
            }

            contador = 0;
            while(contador<3){
                Console.WriteLine($"O nome na posição {contador} é {nomes[contador]}");
                contador++;
            }
        }
    }
}
