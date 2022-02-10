using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder1
{
    internal class SnakeandLadderGame
    {
        int position;
        Random random=new Random();

        public SnakeandLadderGame()
        {
            position = 0;
        }
        public void Derive()
        {
            Console.WriteLine("Position is :" + position);
        }

        public void RollDie()
        {
            int roll = random.Next(1, 7);
            Console.WriteLine("Rolled: " + roll);
            position += roll;
            Derive();
        }


        public void Option(int roll)
        {
            int option=random.Next(0, 3);
            switch (option)
            {
                case 0: Console.WriteLine("no play");
                    break;
                case 1: Ladder1(roll);
                    break;
                case 2:
                    Sanke(roll);
                    break ;

            }
        }
    }
}
