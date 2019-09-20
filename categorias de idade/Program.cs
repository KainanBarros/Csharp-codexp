using System;

namespace categorias_de_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if(idade <=7){

            Console.WriteLine("Você está na categoria Infantil A.");
            }
            else if(idade<=10){
                Console.WriteLine("Você está na categoria Infantil B.");
            }
            else if(idade<=13){
                Console.WriteLine("Você está na categoria Juvenil A.");
            }
            else if(idade<=17){
                Console.WriteLine("Você está na categoria Juvenil B.");
            }
            else{
                Console.WriteLine("Você está na categoria Adulta.");
            }
        }
    }
}
