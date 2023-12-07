using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint6.Task6.V10.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutFileTask6V10.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "nXkwQYzgZ LlckTwkpaAGTvLPc BRW";
            Assert.AreEqual(wait, res);
        }
    }
}
