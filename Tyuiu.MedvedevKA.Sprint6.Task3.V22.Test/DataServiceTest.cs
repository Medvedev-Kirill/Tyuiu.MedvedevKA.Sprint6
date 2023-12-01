using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint6.Task3.V22.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas =  { { 17, 0, 19, -8, -1 },
                             { 9, 4, -5, 7, 15 },
                             { 11, 13, 4, -4, -14 },
                             { 11, 14, 5, -15, 16 },
                             { 2, -14, -2, 11, 11 } };

            int[,] res = ds.Calculate(mas);

            int[,] wait = {{ 17, 0, 19, 0, -1 },
                           { 9, 4, -5, 7, 15 },
                           { 11, 13, 4, -4, -14 },
                           { 11, 14, 5, -15, 16 },
                           { 2, -14, -2, 11, 11 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
