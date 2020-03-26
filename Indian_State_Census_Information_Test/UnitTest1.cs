using IndianStateCensusAnalyzer;
using NUnit.Framework;

namespace Indian_State_Census_Information_Test
{
    [TestFixture]
    public class IndianStateCensusAnalyzer
    {
        private string path = "C:/Users/NK/Downloads/StateCensusData.csv";
        [Test]
        public void indianStateCensusTest_forNumberOfRecords()
        {
            IndianStateCensus indianstateCensus = new IndianStateCensus();
            int numberOfRecords = IndianStateCensus.countOfRecord(path);
            Assert.AreEqual(numberOfRecords, 29);
        }

    }
}