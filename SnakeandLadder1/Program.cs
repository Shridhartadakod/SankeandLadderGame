using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("snake and ladder game");
            SnakeandLadderGame player1 = new SnakeandLadderGame();
            SnakeandLadderGame player2 = new SnakeandLadderGame();
            Console.WriteLine("Player 1: ");
            player1.Derive();
            Console.WriteLine("Player 2: ");
            player2.Derive();
            player1.PlayTillEnd(player2);
            Console.ReadKey();
        }
    }
}
