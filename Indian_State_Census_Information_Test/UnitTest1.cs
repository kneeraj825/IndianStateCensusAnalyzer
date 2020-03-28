using IndianStateCensusAnalyzer;
using static IndianStateCensusAnalyzer.CSVState;
using NUnit.Framework;
using System.IO;
using static IndianStateCensusAnalyzer.IndianStateCensus;

namespace Indian_State_Census_Information_Test
{
    [TestFixture]
    public class IndianStateCensusAnalyzer
    {
        private string PathStateCode = @"C:/Users/NK/Downloads/StateCode.csv";

        [Test]
         public void indianStateCensusTest_forNumberOfRecordsMatch()
         {
           
             string actualpath = "C:/Users/NK/Downloads/StateCode.csv";
             IndianStateCensusAnalyzer indianStateCensus = new IndianStateCensusAnalyzer();
             IndianStateCensus csv = new IndianStateCensus(actualpath);
             //calling with deligate
             CSVData cSVFile = new CSVData(csv.numberOfRecordStateCode);
             int actual = (int)cSVFile();
            int excepted = IndianStateCensus.ReadFile(PathStateCode);
             Assert.AreEqual(CSVState.numberOfRecordStateCode(actualpath), 38);
         }

        [Test]
        public void indianStateCensusTest_forNumberOfRecords()
        {
            string actualpath = "C:/Users/NK/Downloads/StateCode.csv";
            IndianStateCensusAnalyzer indianStateCensus = new IndianStateCensusAnalyzer();
            IndianStateCensus csvstate = new IndianStateCensus(actualpath);
            CSVData csvdata = new CSVData(csvstate.numberOfRecordStateCode);
            string actual = (string)csvdata();
            Assert.AreEqual(actual,"File Not Found");

        }
      
        [Test]
        public void indianStateCensusTest_If_Path_Is_Incorrect_Returns_Custom_Exception()
        {
            string actualpath = "C:/Users/NK/Downloads/StateCode.csv";
            IndianStateCensus csv = new IndianStateCensus(actualpath);
            CSVData cSVFile = new CSVData(csv.numberOfRecordStateCode);
            string actual = (string)cSVFile();
            Assert.AreEqual(actual,"File Not Found");
        }
        [Test]
        public void If_Path_Is_InCorrect_Returns_Custom_Exection()
        {
            string actualpath = "C:/Users/NK/Downloads/StateCode.csv";
            IndianStateCensus csv = new IndianStateCensus(actualpath);
            CSVData cSVFile = new CSVData(csv.numberOfRecordStateCode);
            string actual = (string)cSVFile();
            Assert.AreEqual(actual, "File Format Is Incorrect");
            
        }
        [Test]
        public void If_Csv_File_Is_Correct_But_Delimiter_Is_Incorrect_Returns_Custom_Exection()
        {
            string actualpath = "C:/Users/NK/Downloads/StateCode.csv";
           IndianStateCensus csv = new IndianStateCensus(actualpath,'.');
            CSVData cSVFile = new CSVData(csv.numberOfRecordStateCode);
            string actual = (string)cSVFile();
            Assert.AreEqual(actual,"Delimiter Is Incorrect");
        }
        [Test]
        public void If_Csv_File_Is_Correct_But_Header_Is_Incorrect_Returns_Custom_Exection()
        {
            string actualpath = "C:/Users/NK/Downloads/StateCode.csv";
            IndianStateCensus csv = new IndianStateCensus(actualpath);
            CSVData cSVFile = new CSVData(csv.numberOfRecordStateCode);
            string actual = (string)cSVFile();
            Assert.AreEqual(actual,"Header Is Incorrect");
        }
    }
}