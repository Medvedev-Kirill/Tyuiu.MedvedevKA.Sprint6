using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.MedvedevKA.Sprint6.Task7.V28.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.MedvedevKA.Sprint6\Tyuiu.MedvedevKA.Sprint6.Task7.V28\bin\Debug\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
