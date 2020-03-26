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
            //Exception handling
            try
            {
                if (Path.GetExtension(path) != ".csv")
                {
                    throw new IndianStateCensusException( "File format is incorrect",IndianStateCensusException.Exception.File_Format_Incorrect);
                }
                if (path != "C:/Users/NK/Downloads/StateCensusData.csv")
                {
                    //Throw Exception If File Path Not Match

                    throw new IndianStateCensusException( "File not found",IndianStateCensusException.Exception.File_Not_Found);
                }
                string[] data = File.ReadAllLines(path);
                //Total Number OF Records - 1 Records That For Header not count  
                return data.Length - 1;

            }
            catch (IndianStateCensusException message)
            {
                return message.Message;
            }
        }

    }
}
