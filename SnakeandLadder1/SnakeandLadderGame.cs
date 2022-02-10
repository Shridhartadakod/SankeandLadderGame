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

        public SnakeandLadderGame()
        {
            position = 0;
        }
        public void Derive()
        {
            Console.WriteLine("Position is :" + position);
        }
}
