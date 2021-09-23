using SteveSweeper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveSweeper.Components
{
    public class ConsoleDisplay : IDisplay
    {    
        public void Write(string info)
        {
           Console.Write(info);
        }

        public void WriteLine(string info)
        {
            Console.WriteLine(info);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
