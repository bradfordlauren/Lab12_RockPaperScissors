using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public abstract class Player
    { 
        string name;
        Roshambo roshamboValue;

        //PASSING A VALUE OF Nothing with Roshambo returning.
        public abstract Roshambo generateRoshambo();
           
       
    }
}
