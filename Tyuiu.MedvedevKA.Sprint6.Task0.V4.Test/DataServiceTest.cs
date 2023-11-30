using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint6.Task0.V4.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 68.3;
            Assert.AreEqual(wait, res);
        }
    }
}
