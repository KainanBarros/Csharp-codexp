using System;

namespace CODEDOJO {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Code Dojo");

            string[] Produtos = new string[2];
            double[] Preço = new double[2];
            double soma = 0;
            int Contador = 0;
            int opcoes;
            string resposta = "";

            do {

                Console.WriteLine ("Selecione uma opção");
                Console.WriteLine ("1 - Cadastrar um Produto.");
                Console.WriteLine ("2 - Lista de Produtos.");
                Console.WriteLine ("3 - Calcular Produto");
                Console.WriteLine ("0 - sair");
                opcoes = int.Parse (Console.ReadLine ());

                switch (opcoes) {

                    case 1:
                        Contador = 0;
                        do {
                            if(Contador<2){
                            Console.WriteLine ("Digite um produto:");
                            Produtos[Contador] = Console.ReadLine ();

                            Console.WriteLine ("Digite o valor:");
                            Preço[Contador] = double.Parse (Console.ReadLine ());

                            Console.WriteLine("Quer caastrar mais um produto S/N");
                            resposta = Console.ReadLine().ToUpper();
                            Contador++;
                            }else{
                                Console.WriteLine("Estoque Cheio!");
                            break;
                            }
                        } while (resposta == "S");
                        break;
                    case 2:
                        Console.WriteLine ("Lista de Produtos");
                        Contador = 0;
                        while (Contador < 2) {
                            Console.WriteLine ($"O {Contador+1}° produto {Produtos[Contador]} e seu valor é R${Preço[Contador]} reais. ");
                            Contador++;
                        }
                        break;

                    case 3:
                         Contador = 0;
                            while(Contador <2){
                            soma += Preço[Contador];
                            Contador++;
                            }
                            Console.WriteLine ($"A Soma de Todos os Produtos é: R${soma} reais.");
                         break;
                    case 0:
                    Console.WriteLine("Obrigado por ultilizar nosso Sistema.");
                    break;
                    default:
                    Console.WriteLine("Essa Opção é invalida");
                    break;
                }
            } while (opcoes!=0);

        }
    }
}