using System;
using ApplicantsGuide.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicantsGuideTest
{
    [TestClass]
    public class DirectoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Directory directory = new Directory();
            directory.FillTestData(100);
            Assert.AreEqual("Spetiality0", directory.Universities[0].Spetialities[0].Name);
        }
        //public void TestMethod2()
        //{
        //    Directory directory = new Directory();
        //    directory.FillTestData(100);
        //    Assert.AreEqual("Spetiality0", directory.Universities[0].Spetialities[0].Name);
        //}
    }
}
