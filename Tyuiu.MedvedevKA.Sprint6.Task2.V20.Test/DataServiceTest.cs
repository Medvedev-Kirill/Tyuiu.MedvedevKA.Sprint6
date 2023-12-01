using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint6.Task2.V20.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 7.83;
            valueWaitArray[1] = 6.22;
            valueWaitArray[2] = 6.36;
            valueWaitArray[3] = 6.96;
            valueWaitArray[4] = -0.52;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = -3.30;
            valueWaitArray[7] = -5.53;
            valueWaitArray[8] = -6.25;
            valueWaitArray[9] = -6.63;
            valueWaitArray[10] = -8.24;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
