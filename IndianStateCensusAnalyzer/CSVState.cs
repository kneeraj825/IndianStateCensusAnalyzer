﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    public class CSVState
    {
        public static int numberOfRecordStateCode(string path)
        {
            try
            {
                int count = 0;
                string[] elements = File.ReadAllLines(path);
                IEnumerable<string> element = elements;
                foreach (string e in element)
                {
                    count++;
                }
                return count ;
            }
            catch (IndianStateCensusException)
            {
                throw new IndianStateCensusException(IndianStateCensusException.Exception.File_Not_Found, "File Not Found");
            }
        }
    }
}
