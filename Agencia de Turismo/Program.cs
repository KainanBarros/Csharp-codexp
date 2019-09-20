using System;

namespace Agencia_de_Turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agencia de Turismo");

            string [] nome = new string [2];
            string [] origem = new string [2];
            string [] destino = new string [2];
            DateTime [] data = new DateTime [2];
            
            int opcao = 0;
            int contador = 0;
            
            do
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Cadastrar Passagem");
                Console.WriteLine("2 - Lista Passagem");
                Console.WriteLine("0 - sair");
                opcao = int.Parse(Console.ReadLine());
               //caso 
               switch(opcao){
                   
                   case 1:
                     Console.WriteLine("Vamos cadastrar Agora");
                     string resposta = "";
                     do{
                       if(contador<2){

                     Console.WriteLine("Digite o nome do passageiro:");
                     nome [contador] = Console.ReadLine();
                     
                     Console.WriteLine("Digite a Origem:");
                     origem [contador] = Console.ReadLine();
                     
                     Console.WriteLine("Digite o Destino:");
                     destino [contador] = Console.ReadLine();
                     
                     Console.WriteLine("Digite a Data do Vôo:");
                     data [contador] = DateTime.Parse(Console.ReadLine());

                     Console.WriteLine("Você deseja cadastrar mais um? S/N");
                     resposta = Console.ReadLine().ToUpper();
                     
                     contador++;
                       }else{
                           Console.WriteLine("O número de passagem excedida");
                            break;
                       }
                     
                     }while(resposta == "S");

                   break;
                   case 2:
                    Console.WriteLine("Listando as Passagens");
                        int contadorb = 0;
                        while(contadorb<2){
                            Console.WriteLine($"O {contadorb+1}° Passageiro é {nome[contadorb]} tem Origem de {origem[contadorb]} o destino desse Passageiro é para {destino[contadorb]} data de vôo {data[contadorb]} ");
                            contadorb++;
                        }
                        
                   break;
                   case 0:
                     Console.WriteLine("Obrigado por usar o nosso sistema");
                   break;
                   default:
                     Console.WriteLine("Opção inválida");
                   break;
             }

            }while(opcao !=0);
        }
    }
}
