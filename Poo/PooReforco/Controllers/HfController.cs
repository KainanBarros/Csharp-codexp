using System;
using PooReforco.Models;

namespace PooReforco.Controllers
{
    public class HfController : BaseController
    {
       HFModel hF = new HFModel();
        public string Voar (){
            return "Homem de ferro voando";
        }
        public string Atirar (){
        return "Homem de ferro Atirando";
        }

        public ConsoleColor MudarCor(){
            return ConsoleColor.Red;            
        }
    
    }
}