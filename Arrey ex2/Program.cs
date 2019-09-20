using System;

namespace Arrey_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objetivo Efetuar o cadastro de usúario com os seguintes 
            //dado Nome, Telefone e Email de 5 usuário;
            Console.WriteLine("Exercício de Array 2");

            string[] nomes = new string[2];
            string[] telefone = new string [2];
            string[] email = new string[2];

             int contador = 0;
             while(contador <=1){
                 Console.WriteLine("Digite o seu nome:");
                 nomes [contador] = Console.ReadLine();

                 Console.WriteLine("Digite o seu telefone:");             
                 telefone [contador] = Console.ReadLine();

                 Console.WriteLine("Digite seu email:");
                 email [contador] = Console.ReadLine();
                 
                 contador++;
             }
              int contadorb = 0;
             while(contadorb<=1){
                 Console.WriteLine($" O cliente número {contadorb+1} - nome:{nomes[contadorb]}, telefone:{telefone[contadorb]}, email:{email[contadorb]}");

                 contadorb++;
             }
        }
    }
}
