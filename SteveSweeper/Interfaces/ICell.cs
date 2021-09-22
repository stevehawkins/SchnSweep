using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveSweeper.Interfaces
{
    public interface ICell
    {
        bool IsBomb { get;  }
        string Location { get; set; }
    }
}
