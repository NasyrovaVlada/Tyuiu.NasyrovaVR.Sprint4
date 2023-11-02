using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint4.Task2.V22.Lib;

namespace Tyuiu.NasyrovaVR.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 5, 3, 4, 2, 6, 2, 5, 5, 5, 4, 2, 2 };
            int res = ds.Calculate(numsArray);
            int wait = 23;
            Assert.AreEqual(wait, res);
        }
    }
}
