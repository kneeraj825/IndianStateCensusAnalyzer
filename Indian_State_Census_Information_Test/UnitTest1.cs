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
            Assert.AreEqual(IndianStateCensus.countOfRecord(path), 29);
        }
        [Test]
        public void indianStateCensusTest_ifFileCorrectButTypeIncorrect_returnsCustomException()
        {
            string realPath = "C:/Users/NK/Downloads/StateCensusData.csv";
            Assert.AreEqual("File format incorrect", IndianStateCensus.countOfRecord(realPath));
        }

    }
}