using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Periods
{
    class Program
    {
        static void Main()
        {
            var periods = new List<Period>
            {
                new Period (1, 3),
                new Period (3, 5),
                new Period (6, 10),
                new Period (8, 10),
                new Period (12, 15),
                new Period (13, 18),
                new Period (20, 24),
                new Period (22, 25),
                new Period (27, 30),
            };
            
            var sortedPeriods = periods.OrderBy(i => i.Start).ToList();
            
            PrintPeriods(sortedPeriods);
            
            var periodsSolver = new PeriodsSolver(sortedPeriods);

            var result = periodsSolver.Solve();
            foreach (var period in result)
            {
                Console.WriteLine(period);
            }
           


        }

        static void PrintPeriods(IEnumerable<Period> sortedPeriods)
        {
            Console.WriteLine("Sorted List with periods:");
            foreach (var a in sortedPeriods)
            {
                Console.WriteLine($"Start: {a.Start} End: {a.End}");
            }
            
        }
    }
}