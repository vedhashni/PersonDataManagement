using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PersonDataManagementProblem;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        List<Person> list = new List<Person>();
        [TestMethod]
        public void TestMethodForRetrieveTopTwoLessThan60()
        {
            ///AAA Method
            bool expected = true;
            var actual = PersonDetails.RetrieveTopTwoRecordsLessThan60(list);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForRetrieveTeenageRecords()
        {
            ///AAA Method
            bool expected = true;
            var actual = PersonDetails.RetrieveTeenageRecords(list);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForCalculateAverageAge()
        {
            ///AAA Method
            bool expected = true;
            var actual = PersonDetails.CalculateAverageAge(list);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForSearchingSpecificName()
        {
            ///AAA Method
            bool expected = true;
            var actual = PersonDetails.SearchingSpecificName(list, "Arun");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForSkipRecordLessThan60()
        {
            ///AAA Method
            bool expected = true;
            var actual = PersonDetails.SkipRecordLessThan60(list);
            Assert.AreEqual(expected, actual);
        }
    }
}
