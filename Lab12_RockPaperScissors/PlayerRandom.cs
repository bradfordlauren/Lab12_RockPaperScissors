using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
  public class PlayerRandom : Player
    {
        public override Roshambo generateRoshambo()
        {
            //Make a random # generator

            Random roshamboRandomGenerator = new Random();
          
            //match one of the # with the Roshambo values
     int randomNumberReturned = roshamboRandomGenerator.Next(1, 4);
            
            //return the value
     return (Roshambo)randomNumberReturned;
        }
    }
}
