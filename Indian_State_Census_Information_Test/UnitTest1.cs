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
            Assert.AreEqual(CSVState.numberOfRecordStateCode(path), 37);
        }
        [Test]
        public void indianStateCensusTest_forNumberOfRecordsMatch()
        {
            Assert.AreEqual(CSVState.numberOfRecordStateCode(path), 38);
        }
        [Test]
        public void indianStateCensusTest_If_Path_Is_Incorrect_Return_Custom_Exception()
        {
            Assert.AreEqual(CSVState.numberOfRecordStateCode(path),"File Not Found");
        }
        [Test]
        public void If_Path_Is_InCorrect_Return_Custom_Exection()
        {
            Assert.AreEqual(CSVState.numberOfRecordStateCode(path),"File Format Is Incorrect");
        }

    }
}