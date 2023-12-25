using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five_in_line
{
    public class Cell

    {
        public enum CellState

        {
            Empty,
            Cross,
            Nought

        }
        public CellState State { get; set; }
    }
}
