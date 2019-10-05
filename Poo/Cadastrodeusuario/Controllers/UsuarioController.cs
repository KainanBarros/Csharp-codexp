using System;
using System.Collections.Generic;
using Cadastrodeusuario.Models;

namespace Cadastrodeusuario.Controllers
{
    public class UsuarioController
    {
        List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
        /// <summary> Método para cadastro de usuário</summary>>

        public void CadastroUsuario ()
        {
            Console.Clear();
            Console.WriteLine("Digitar o Nome");
            string nome = Console.ReadLine();

            Console.WriteLine("informe seu E-Mail");
            string email = Console.ReadLine();
            
            Console.WriteLine("Infome sua Senha");
            string senha = Console.ReadLine();
            
            //Instanciando um novo usuário
            UsuarioModel usuario = new UsuarioModel();

            //Populando o Objeto
            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add(usuario);
        
        }//fim CadastroUsuario

        public void ListarUsuarios()
        {    
         //Enquanto p item in pasta faça   
         foreach(var item in listaDeUsuarios)
         {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine($"Usuario : {item.Nome}");
            Console.WriteLine($"Id: {item.Id}");
            Console.WriteLine($"E-Mail: {item.Email}");
            Console.WriteLine($"Data do Cadastro : {item.DataCriacao}");
            Console.WriteLine($"--------------------");
         }//Fim do Foreach
        }//Fim da função listar

        public bool logar()
        {
        Console.Clear();    
        Console.WriteLine("Insira o E-Mail:");
        string email = Console.ReadLine();
        
        
        Console.WriteLine("Insira sua Senha:");
        string senha = Console.ReadLine();
        
        foreach (var item in listaDeUsuarios)
         {
            if(item.Email == email && item.Senha == senha){
                return true;
        }//Fim if
        }//Fim Foreach
            return false;
        }//Fim da Função

    }//Fim da Class
}