using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RPGDERP.Models
{
    class Game
    {
        public void Start()
        {
            Clear();
            WriteLine("Testing the game");
            string[,] grid =
            {
                {"=","=","=","=" },
                {"="," "," ","X" },
                {"O"," ","=","=" },
                {"="," ","="," " },
                {"=","=","=","=" }
            };
            World newWorld = new World(grid);
            newWorld.Draw();
            
        }
    }
}
