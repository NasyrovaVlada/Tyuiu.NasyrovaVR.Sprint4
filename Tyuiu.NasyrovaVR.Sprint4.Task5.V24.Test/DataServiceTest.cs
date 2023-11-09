using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint4.Task5.V24.Lib;

namespace Tyuiu.NasyrovaVR.Sprint4.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { { -6, 6, 4, -5, 1 },
                                         { -5, 2, 5, -7, 6 },
                                         { 0, -4, 3, 5, 6 },
                                         { -1, 4, 2, 4, -5 },
                                         { 6, 6, 0, 1, 6 } };
            int res = ds.Calculate(mas);
            int wait = 16;
            Assert.AreEqual(wait, res);
        }
    }
}
