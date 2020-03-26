using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    public class IndianStateCensus
    {
        //Method to return number of record count
        public static int countOfRecord(string path)
        {
            string[] data = File.ReadAllLines(path);
            //For header total record - 1
            return data.Length - 1;
        }
    }
}
