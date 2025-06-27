using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _071_ExercicioFixacao_Vetores
{
    class Cliente
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }

     
        public override string ToString()
        {
            return                
                + NumeroQuarto
                +": " +  Name +", "+ Email+ " .";
        }
    }


}
