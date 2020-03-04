using System;
using System.Collections.Generic;
using System.Text;

namespace Periods
{
    public class Period
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Period(int start, int end)
        {
            Start = start;
            End = end;
        }
        
        public override string ToString()
        {
            return $"{Start} : {End}";
        }
    }

    
}