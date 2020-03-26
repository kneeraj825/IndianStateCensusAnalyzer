using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    class StateCensus
    {
        public static int getNumberOfRecords(string path)
        {
            int count = 0;
            string[] elements = File.ReadAllLines(path);
            IEnumerable<string> ele = elements;
            foreach (var element in ele)
            {
                count++;
            }
            // Return Number of count - 1 for header is not count 
            return count - 1;
        }
    }
}

