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
        public string header = "SrNo,State,Name,TIN,StateCode";
        // Deligate
        public delegate object CSVData();
        public IndianStateCensus(string path)
        {
            this.path = path;
        }
        public IndianStateCensus(string path, char delimiter)
        {
            this.path = path;
            this.delimiter = delimiter;
        }
        public IndianStateCensus(string path, string header)
        {
            this.path = path;
            this.header = header;
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
                if (data[0] != header)
                {
                    throw new IndianStateCensusException(IndianStateCensusException.Exception.HEADER_INCORRECT, "Header Is Incorrect");
                }
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

        public static int ReadFile(string pathStateCode)
        {
            throw new NotImplementedException();
        }
    } 
}
