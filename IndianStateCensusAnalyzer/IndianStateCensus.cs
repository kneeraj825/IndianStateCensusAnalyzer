using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    public class IndianStateCensus
    {
       public int ReadFile(string path)
        {
            string[] data = File.ReadAllLines(path);
            return data.Length;
        }
    }
}
