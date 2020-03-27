using IndianStateCensusAnalyzer;
using NUnit.Framework;
using System.IO;

namespace Indian_State_Census_Information_Test
{
    [TestFixture]
    public class IndianStateCensusAnalyzer
    {
        private string path = "C:/Users/NK/Downloads/StateCode.csv";
        [Test]
        public void indianStateCensusTest_forNumberOfRecords()
        {
            Assert.AreEqual(CSVState.numberOfRecord(path), 37);
        }
        [Test]
        public void indianStateCensusTest_forNumberOfRecordsMatch()
        {
            Assert.AreEqual(CSVState.numberOfRecord(path), 38);
        }

    }
}