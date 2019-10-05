using System;
using VigadoresMVC.Models;

namespace VigadoresMVC.Controllers
{
    public class VingadoreController
    {
        public void Capitaoamerica(){
            CapitaoAmericaModel cA = new CapitaoAmericaModel();

            Console.Clear();
            string vida = "100 HP";
            string equipe  = "Capitão América";
            string cor = "Azul";
            
            
            cA.Vida = vida;
            cA.Equipe = equipe;
            cA.Cor = cor;
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine("Olá sr. roger aqui vai algumas informações que é importante saber");
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine($"Vida: {cA.Vida}");
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine($"Equipe: {cA.Equipe}");
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine($"Cor do seu time : {cA.Cor}");
            System.Console.WriteLine("-------------------------------");
            Console.ResetColor();
            int opcao;
            do{
                System.Console.WriteLine("Escolha Uma Ação");
                System.Console.WriteLine("1 - Atacar");
                System.Console.WriteLine("2 - Defender");
                System.Console.WriteLine("0 - Mudar de Personagem");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1 :
                    string escudoa= "Lançar escudo";
                     Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine($"{cA.Esculdo = escudoa }");
                    Console.ResetColor();
                    break;

                    case 2:
                    string escudod= "Defender-se com o escudo";
                     Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine($"{cA.Esculdo = escudod}");
                    Console.ResetColor();
                    break;

                    case 0:
                    //escolheu Outro Personagem
                    break;
                    default:
                    System.Console.WriteLine("Opção Inválida");
                    break;
                }    
            }while(opcao!=0);
        }
        public void HomemDeFerro(){
            HomemDeFerroModel hF = new HomemDeFerroModel();
          
            Console.Clear();
            string vida = "100 HP";
            string equipe  = "Homem de Ferros";
            string cor = "Vermelho";
            
            hF.Vida = vida;
            hF.Equipe = equipe;
            hF.Cor = cor;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine("Olá sr. stark aqui vai algumas informações que é importante saber");
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine($"Vida: {hF.Vida}");
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine($"Equipe: {hF.Equipe}");
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine($"Cor do seu time : {hF.Cor}");
            Console.ResetColor();

            int opcao;
            do{
                System.Console.WriteLine("Escolha Uma Ação");
                System.Console.WriteLine("1 - Atirar");
                System.Console.WriteLine("2 - Voar");
                System.Console.WriteLine("0 - Mudar de Personagem");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1 :
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    string armaduraa= " ︻╦̵̵̿╤─ ҉ - - - - - - -";
                     Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine($"{hF.Armadura = armaduraa }");
                    Console.ResetColor();
                    break;

                    case 2:
                    string armadurav= "Voar";
                     Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine($"{hF.Armadura = armadurav}");
                    Console.ResetColor();
                    break;

                    case 0:
                    //escolheu Outro Personagem
                    System.Console.WriteLine("Carregando outros Personagens");
                    break;
                    default:
                    System.Console.WriteLine("Opção Inválida");
                    break;
                }    
            }while(opcao!=0);
        }
    }
}