using IndianStateCensusAnalyzer;
using NUnit.Framework;
using System.IO;

namespace Indian_State_Census_Information_Test
{
    [TestFixture]
    public class IndianStateCensusAnalyzer
    {
        private string path = "C:/Users/NK/Downloads/StateCensusData.csv";
        [Test]
        public void indianStateCensusTest_forNumberOfRecords()
        {
            IndianStateCensus indianstatecsensus = new IndianStateCensus(path);
            Assert.AreEqual(indianstatecsensus.countOfRecord(), 29);
        }
        [Test]
        public void stateCensusTest_ifCorrectButTypeIncorrect_returnsCustomException()
        {
            string actualPath = "C:/Users/NK/Downloads/StateCensusData.csv";
            IndianStateCensus indiancensus = new IndianStateCensus(actualPath);
            Assert.AreEqual("File format incorrect",indiancensus.countOfRecord(),"File Not Found");
        }
        [Test]
        public void If_Path_Is_Correct_Extension_Is_Incorrect()
        {
            string actualPath1 = "C:/Users/NK/Downloads/StateCensusData.csv";
            IndianStateCensus indiancensus1 = new IndianStateCensus(actualPath1);
            Assert.AreEqual(indiancensus1.countOfRecord(),"File Format Is Incorrect");
        }
        [Test]
        public void File_Is_Correct_But_Delimiter_Is_Incorrect()
        {
            string actualPath2 = "C:/Users/NK/Downloads/StateCensusData.csv";
            IndianStateCensus indiancensus2 = new IndianStateCensus(actualPath2);
            Assert.AreEqual(indiancensus2.countOfRecord(), "Deliiter Is Incorrect");
        }
    }
}