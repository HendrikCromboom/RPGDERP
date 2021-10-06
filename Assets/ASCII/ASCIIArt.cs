using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDERP.Assets.ASCII
{
    class ASCIIArt
    {
        public string GameTitle = @"
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
        public string DrawGameTitle()
        {
            return GameTitle;
        }
    }
}
