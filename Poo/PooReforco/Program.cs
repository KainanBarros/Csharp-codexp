using System;
using PooReforco.Controllers;

namespace PooReforco
{
    class Program
    {
        static void Main(string[] args)
        {
        CapController cap = new CapController();
        HfController hf = new HfController();

        string personagem;


        do{


        Console.WriteLine("Digite : \n 1-Homem de ferro \n 2-Capitão américa \n 0-Sair");
        personagem = Console.ReadLine();
        
        if(personagem=="1"){
            Console.ForegroundColor = hf.MudarCor();
            Console.WriteLine("Você está jogando com o Homem de ferro");
            Console.WriteLine(hf.Atirar()); 
            Console.WriteLine( hf.Pular());
            Console.WriteLine(hf.Voar());
            Console.ResetColor();
        } else if(personagem == "2"){
            Console.ForegroundColor = cap.MudarCor();
            Console.WriteLine(cap.MostraInfo());
            Console.WriteLine("Você está jogando com o capitão América");
            Console.WriteLine(cap.Lançar()); 
            Console.WriteLine( cap.Pular());
            Console.WriteLine(cap.Defender());
            Console.ResetColor();
        }else{
            System.Console.WriteLine("Personagem inválido");
        }

        }while(personagem != "0");
        }
    }
}
