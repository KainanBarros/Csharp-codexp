using System;

namespace Media_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media de notas");
            Console.WriteLine("---------------------------------------");

            int [] nota1 = new int [5];
            int [] nota2 = new int [5];
            double [] media = new double[5];
            int contador = 0;
            int aprovados = 0;
            int reprovados = 0;
            
            do{
                Console.WriteLine("Digite a Primeira Nota:");
                nota1[contador] = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite a segunda Nota:");
                nota2[contador] = int.Parse(Console.ReadLine());

                media[contador] = (nota1[contador] + nota2[contador])/2;

                if(media[contador] >= 7){
                    aprovados++;
                }
                else{
                    reprovados++;
                }
                contador++;
            }while(contador< 5);
        
            int contadorb = 0;
            double somamedia = 0;
            while(contadorb <5){
                somamedia = somamedia+media[contadorb];
            contadorb++;
            }

            Console.WriteLine($"A média da sala é {somamedia/5} temos {aprovados} Aprovados e {reprovados} reprovados ");
        
        }
    }
}