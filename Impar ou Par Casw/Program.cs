using System;

namespace Impar_ou_Par_Casw
{
    class Program
    {
        static void Main(string[] args)
    {
            Console.WriteLine("Par ou Ímpar");

            Console.WriteLine("Digite o primeiro número");
            float n1 = float.Parse(Console.ReadLine());

             Console.WriteLine("Digite o segundo número");
             float n2 = float.Parse(Console.ReadLine());

             float conta1 = n1 % 2;
             float conta2 = n2 % 2;
            

             switch(conta1){
                 case 1:
                 Console.WriteLine("O primeiro número é Ímpar");
                 break;

                 case 0:
                 Console.WriteLine("O primeiro número é Par");
                 break;

                 default:
                 Console.WriteLine("Digite um número");
                 break;}

             switch(conta2){
                 case 1:
                 Console.WriteLine("O segundo número é Ímpar");
                 break;

                 case 0:
                 Console.WriteLine("O segundo número é Par");
                 break;

                 default:
                 Console.WriteLine("Digite um número");
                 break;}

                 if(n1>n2){
                    Console.WriteLine($"O número {n1} é maior que número {n2}. ");
                 }else if(n2>n1){
                     Console.WriteLine($"O número {n2} é maior que número {n1}. ");
                 }
                 else{
                     Console.WriteLine("Ambos os números tem o mesmo valor.");
                 }
    }
  }
}
