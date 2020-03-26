using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    class IndianStateCensusException :Exception
    {
        private string message;
        public Exception type;
        public enum Exception
        {
            File_Not_Found, File_Format_Incorrect
        }
        public IndianStateCensusException(string _message,Exception _type)
        {
            this.message = _message;
            this.type = _type;
        }
        public IndianStateCensusException(string message) : base(message)
        {
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
