using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    public class IndianStateCensusException : Exception
    {
        string message;
        public Exception type;
        public enum Exception
        {
            File_Not_Found, File_Format_Incorrect, DELIMITER_INCORRECT
        }
        public IndianStateCensusException(Exception type, string message)
        {
            this.message = message;
            this.type = type;
        }
        public IndianStateCensusException(string message, Exception type) : base(message)
        {
            this.message = message;
            this.type = type;
        }
        public override string Message
        {
            get
            {
                return this.message;
            }
        }
    }   
}
