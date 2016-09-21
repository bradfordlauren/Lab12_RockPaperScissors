using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    class Player3 : Player
    {
        public override Roshambo generateRoshambo()
        {
            return Roshambo.Scissors;
   }
    }
}
