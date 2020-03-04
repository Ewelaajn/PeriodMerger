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
                new Period (1, 5),
                new Period (3, 5),
                new Period (5, 10),
                new Period (4, 8),
                new Period (7, 13),
                new Period (8, 15),
                new Period (13, 20),
                new Period (15, 25),
                new Period (17, 20),
                new Period (27, 30),
                new Period (28, 29),
                new Period (29, 30),
                new Period (27, 29),
                new Period (23, 25),
                new Period (21, 29),
                new Period (22, 25),
                new Period (21, 28),
                new Period (18, 20),
                new Period (17, 27),
                new Period (15, 25)
            };
            
            var sortedPeriods = periods.OrderBy(i => i.Start).ToList();
            
            PrintPeriods(sortedPeriods);
            
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