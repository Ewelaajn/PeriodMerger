using System;
using System.Collections.Generic;
using System.Text;

namespace Periods
{
    class Period
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Period(int start, int end)
        {
            Start = start;
            End = end;
        }
    }

    
}