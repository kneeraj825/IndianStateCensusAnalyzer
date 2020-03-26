using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    public class IndianStateCensus
    {
        public static object countOfRecord(string path)
        {

            //Exception
            try
            {
                if (path != "C:/Users/NK/Downloads/StateCensusData.csv")
                {
                    //Throw Exception If File Path Not Match
                    throw new IndianStateCensusException("File Not Match");
                }
                string[] data = File.ReadAllLines(path);
                //Total Number OF Records - 1 Records That For Header 
                return data.Length - 1;

            }
            catch (IndianStateCensusException message)
            {
                return message.Message;
            }
        }

    }
}
