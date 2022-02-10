using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder1
{
    internal class SnakeandLadderGame
    {
       private int position;
        private bool wincheck;
        private int totalDieRoll;
        Random random=new Random();

        public SnakeandLadderGame()
        {
            position = 0;
            wincheck = false;
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
                case 1: 
                    Ladder(roll);
                    break;
                case 2:
                    Snake(roll);
                    break ;
                    default: Console.WriteLine("Error!");
                    break ;

            }
        }
        private void Snake(int roll)
        {
            Console.WriteLine(" Snake bite!!!");
            Console.WriteLine("Going down by " + roll);
            position -= roll;
        }

        private void Ladder(int roll)
        {
            Console.WriteLine(" A Ladder!!!");
            Console.WriteLine("Going up by " + roll);
            position += roll;
        }

        private int CheckBoundary(int displacement)
        {
            if (position < 0)
            {
                position = 0;
                return 0;
            }
            else if (position > 100)
            {
                position -= displacement;
                Console.WriteLine(" You shot past position 100");
                Console.WriteLine("You are moved back to previous position");
                return 0;
            }
            else
                return 1;
        }
        private int MovePlayer(int displacement)
        {
            position += displacement;
            if (position == 100)
            {
                wincheck = true;
                return 0;
            }
            return CheckBoundary(displacement);
        }

        public void PlayTillEnd(SnakeandLadderGame player2)
        {
            while (this.wincheck is false && player2.wincheck is false)
            {
                {
                    Console.WriteLine("\nPlayer 1 turn: ");
                    this.RollDie();
                    this.Derive();
                    if (this.wincheck is true)
                        break;
                    Console.WriteLine("\nPlayer 2 turn: ");
                    player2.RollDie();
                    player2.Derive();
                }
                if (player2.wincheck is true)
                    Console.WriteLine("Congratulations Player 2  Won");
                else
                    Console.WriteLine("Congratulations Player 1  Won!!");
                Console.WriteLine("Player 1 Total die rolls: " + this.totalDieRoll);
                Console.WriteLine("Player 2 Total die rolls: " + player2.totalDieRoll);
            }
        }
                
        }
}

