using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    public class StateCensus
    {
        public static int getNumberOfRecords(string path)
        {
                try
                {
                    //count++;
                    int count = 0;
                    string[] elements = File.ReadAllLines(path);
                    IEnumerable<string> element = elements;
                    foreach (string e in element)
                    {
                        count++;
                    }
                    return count - 1;
                }
                catch (IndianStateCensusException)
                {
                    throw new IndianStateCensusException(IndianStateCensusException.Exception.File_Not_Found, "File Not Found");
                }
        }
    }
}

