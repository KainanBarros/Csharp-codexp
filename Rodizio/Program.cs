using System;

namespace Rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saiba que dia é o rodizio do seu carro");

            Console.WriteLine("Digite a placa do seu carro");
            
            string placa = Console.ReadLine();

           int caracteres = placa.Length;

           int final = int.Parse(placa.Substring(caracteres -1));

            if(final ==0 || final ==1 ){
                Console.WriteLine("O rodizio do seu carro é Segunda-feira");
            }
             else if(final ==2 || final ==3 ){
                Console.WriteLine("O rodizio do seu carro é Terça-feira");
            }
             else if(final ==4 || final ==5 ){
                Console.WriteLine("O rodizio do seu carro é Quarta-feira");
            }
             else if(final ==6 || final ==7 ){
                Console.WriteLine("O rodizio do seu carro é Quinta-feira");
            }
             else if(final ==8 || final ==9 ){
                Console.WriteLine("O rodizio do seu carro é Sexta-feira");
            }
                else{
                    Console.WriteLine("Placa não encontrada");
                }
        }
    }
}
