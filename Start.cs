using RPGDERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RPGDERP
{
    class Start
    {
        public void StartMenu()
        {
            string prompt = @"
 ██▀███   ██▓███    ▄████    ▓█████▄ ▓█████  ██▀███   ██▓███  
▓██ ▒ ██▒▓██░  ██▒ ██▒ ▀█▒   ▒██▀ ██▌▓█   ▀ ▓██ ▒ ██▒▓██░  ██▒
▓██ ░▄█ ▒▓██░ ██▓▒▒██░▄▄▄░   ░██   █▌▒███   ▓██ ░▄█ ▒▓██░ ██▓▒
▒██▀▀█▄  ▒██▄█▓▒ ▒░▓█  ██▓   ░▓█▄   ▌▒▓█  ▄ ▒██▀▀█▄  ▒██▄█▓▒ ▒
░██▓ ▒██▒▒██▒ ░  ░░▒▓███▀▒   ░▒████▓ ░▒████▒░██▓ ▒██▒▒██▒ ░  ░
░ ▒▓ ░▒▓░▒▓▒░ ░  ░ ░▒   ▒     ▒▒▓  ▒ ░░ ▒░ ░░ ▒▓ ░▒▓░▒▓▒░ ░  ░
  ░▒ ░ ▒░░▒ ░       ░   ░     ░ ▒  ▒  ░ ░  ░  ░▒ ░ ▒░░▒ ░     
  ░░   ░ ░░       ░ ░   ░     ░ ░  ░    ░     ░░   ░ ░░       
   ░                    ░       ░       ░  ░   ░              
                              ░                           ";
            string[] options = { "Play", "Options", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch(selectedIndex)
            {
                case 0:
                    LaunchGame();
                    break;
                case 1:
                    DisplayOptions();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }
        private void ExitGame()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
        private void DisplayOptions()
        {
            WriteLine("Nothing here yet");
            WriteLine("Press any key to return to the menu");
            ReadKey(true);
            StartMenu();
        }
        private void LaunchGame()
        {
            Game currentGame = new Game();
            currentGame.Start();
        }
    }
}
