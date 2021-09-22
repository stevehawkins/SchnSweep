using SteveSweeper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveSweeper.Components
{
    public sealed class BombCell : ICell
    {
        public bool IsBomb { get => true; }
        public string Location { get; set; } = string.Empty;
    }
}
