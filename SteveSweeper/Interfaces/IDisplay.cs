using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveSweeper.Interfaces
{
    public interface IDisplay
    {
        void WriteLine(string info);
        void Write(string info);
        string ReadLine();
    }
}
