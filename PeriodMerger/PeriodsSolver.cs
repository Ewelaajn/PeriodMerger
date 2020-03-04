using System.Collections.Generic;
using System.Linq;

namespace Periods
{
    public class PeriodsSolver
    {
        private readonly IEnumerable<Period> _periods;

        public PeriodsSolver(IEnumerable<Period> sortedPeriods)
        {
            _periods = sortedPeriods;
        }
        
        public IEnumerable<Period> Solve()
        {
            var stack = new Stack<Period>();
            
            foreach (var period in _periods)
            {
                if (stack.Count == 0)
                {
                    stack.Push(period);
                }
                else if (stack.Peek().End >= period.Start)
                {
                    var previousPeriod = stack.Pop();
                    int newEnd = 0;
                    
                    if (previousPeriod.End >= period.End)
                    {
                        newEnd = previousPeriod.End;
                    }
                    else
                    {
                        newEnd = period.End;
                    }
                    
                    var newPeriod = new Period(previousPeriod.Start, newEnd);
                    
                    stack.Push(newPeriod);
                }
                else if (period.Start > stack.Peek().End)
                {
                    stack.Push(period);
                }
            }
            
            return stack.ToList();
        }
    }
}