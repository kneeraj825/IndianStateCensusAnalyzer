using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    public class IndianStateCensus
    {
        public string path;
            public object numberOfRecordStateCode()
            {
                //Exception handling
                try
                {
                    if (path != "C:/Users/NK/Downloads/StateCode.csv")
                    {
                        //Throw Exception If File Path Not Match

                        throw new IndianStateCensusException("File not found", IndianStateCensusException.Exception.File_Not_Found);
                    }
                    string[] data = File.ReadAllLines(path);
                    return data.Length - 1;
                }
                catch (IndianStateCensusException message)
                {
                    return message.Message;
                }
            }



    } 
}
