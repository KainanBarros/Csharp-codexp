using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informações do fisíco Humano");

            string [] nome = new string [4];
            int [] idade = new int [4];
            double [] peso = new double [4];
            double [] altura = new double [4];
            string [] sexo = new string [4];
            int sexom= 0;
            int sexof = 0;
            int idadem = 0;
            int idadef = 0;
            
            for(int i = 0; i <4; i++){
                
                Console.WriteLine("Digite seu Nome:");
                nome [i] = Console.ReadLine();

                Console.WriteLine("Digite idade");
                idade [i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o peso");
                peso [i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite altura");
                altura [i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Sexo M/F");
                sexo [i] = Console.ReadLine().ToUpper();
                
            }//Fim do for!!!
            
                    
            for(int i = 0; i < 4; i++ ){
                   
               if(sexo [i] == "M"){
                   sexom++;
                   idadem += idade[i];
               }else{
                   sexof++;
                   idadef += idade[i];
               }
            }//Fim do for!!!
            
            int resultm = idadem/sexom;
            int resultf = idadef/sexof;
            int total = sexom+sexof;

            Console.WriteLine($"O programa resgitrou o total de {total} pessoas, sendo {sexom} sexo masculino e {sexof} sexo feminino.");
            Console.WriteLine($"A idade média dos Homens são de {resultm} anos e a idade média das mulheres são de {resultf} anos.");
            
            double [] imc = new double [4];

            for(int i = 0; i < 4; i++){
                
                imc [i] = peso [i] /(altura[i]*altura[i]);

                Console.WriteLine($"{i+1}° {nome[i]} seu IMC é de {imc[i]}");
                Console.WriteLine("-----------------------------------------------");

            }
            }
    }
}
