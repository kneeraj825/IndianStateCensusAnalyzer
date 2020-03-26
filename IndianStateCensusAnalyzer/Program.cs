using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Indian State Census Analyzer");
            IndianStateCensus abs = new IndianStateCensus();
            IEnumerable<string> iterating = abs.CsvReader();
            foreach (string finalPrint in iterating)
            {
                Console.WriteLine(finalPrint);
            }

        }
    }
}
