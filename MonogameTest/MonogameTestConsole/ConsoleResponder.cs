using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonogameTestConsole
{
    class ConsoleResponder : MonogameTestMain.IResponder
    {
        public void ChangeBackgroundColor()
        {
            Console.WriteLine("now the color in front of you is red, how cool is that? 2 seconds later, it's now blue.");
        }
    }
}
