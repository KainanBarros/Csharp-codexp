using System;
using Cadastrodeusuario.Controllers;

namespace Cadastrodeusuario {
    /// <summary>
    ///Cadastro de usuário
    /// usando lista e cvm
    ///E autenticação
    /// </summary>

    class Program {
        static void Main (string[] args) {
            UsuarioController usuarioController = new UsuarioController (); //Instancia a Class para Cria um objeto
            int opcao;
            do {
                Console.WriteLine ("1 - Cadastrar Usuário");
                Console.WriteLine ("2 - Listar Usuário");
                Console.WriteLine ("3 - Autenticação");
                Console.WriteLine ("0 - Sair");
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        //Cadastrar
                        usuarioController.CadastroUsuario ();
                        break;

                    case 2:
                        //Listar
                        usuarioController.ListarUsuarios ();
                        break;

                    case 3:
                        //Autenticação Email e Senha!!!
                        bool usurioRetornado = usuarioController.logar ();
                        if(usurioRetornado)//se o usuarioRetorno for True
                        {
                            Console.WriteLine("Usuario Localizado");
                        }else{
                            Console.WriteLine("Usuário Não Encontrado");
                        }
                        break;
                    case 0:
                        //Sair
                        Console.WriteLine ("Tchau");
                        break;
                    default:
                        Console.WriteLine ("Opção Invalida");
                        break;
                }

            } while (opcao != 0);
        }
    }
}