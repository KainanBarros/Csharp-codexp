using System;
using PooReforco.Models;

namespace PooReforco.Controllers
{
    public class CapController : BaseController
    {
        CapModel cap = new CapModel();

        public string Lançar (){
            return "Lançou Escudo";
        }
        public string Defender (){
            return "Defender-se com Escudo";
        }
        public ConsoleColor MudarCor(){
        return ConsoleColor.Blue;            
        }
    }
}