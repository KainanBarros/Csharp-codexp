using System;

namespace Impar_e_Par
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra que número é Ímpar e Par");

            Console.WriteLine("Digite o Primeiro número");
            float n1= float.Parse(Console.ReadLine());

            if(n1 % 2 == 0){
            Console.WriteLine("Número par.");
            }else {
                Console.WriteLine("Numero é impar.");
            }
            Console.WriteLine("Digite o Segundo número");
            float n2= float.Parse(Console.ReadLine());
        
            if(n2 % 2 ==0) {
            Console.WriteLine("Número par.");
            }
            else{
                Console.WriteLine("Número Ímpar");
            }
            
            if(n1>n2){
                Console.WriteLine($"O número {n1} é maior que o número {n2}");                
            }
            else if(n2>n1){
                Console.WriteLine($"O número {n2} é maior que o número {n1}");
            }
            else{
                Console.WriteLine("Ambos tem o mesmo valor.");
            }
        
        
        }
    }
}

