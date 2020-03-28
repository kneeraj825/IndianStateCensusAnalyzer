using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    public class IndianStateCensus
    {
        public string path;
        public char delimiter = ',';
        public IndianStateCensus(string path)
        {
            this.path = path;
        }
        public IndianStateCensus(string path, char delimiter)
        {
            this.path = path;
            this.delimiter = delimiter;
        }
        public object numberOfRecordStateCode()
            {
                //Exception handling
                try
                {
                if (Path.GetExtension(path) != ".csv")
                {
                    throw new IndianStateCensusException("File format is incorrect", IndianStateCensusException.Exception.File_Format_Incorrect);
                }
                if (path != "C:/Users/NK/Downloads/StateCode.csv")
                    {
                        //Throw Exception If File Path Not Match

                        throw new IndianStateCensusException("File not found", IndianStateCensusException.Exception.File_Not_Found);
                    }
                    string[] data = File.ReadAllLines(path);
                foreach (var element in data)

                {
                    if (!element.Contains(delimiter))
                    {
                        throw new IndianStateCensusException(IndianStateCensusException.Exception.DELIMITER_INCORRECT, "Delimiter is incorrect");
                    }
                }
                return data.Length - 1;
                }
                catch (IndianStateCensusException message)
                {
                    return message.Message;
                }
            }



    } 
}
