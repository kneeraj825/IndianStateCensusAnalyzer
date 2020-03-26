using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyzer
{
    class IndianStateCensusException :Exception
    {
            string message;
        public IndianStateCensusException(string message)
            {
                this.message = message;
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
