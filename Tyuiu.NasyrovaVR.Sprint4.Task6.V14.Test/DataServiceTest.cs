using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint4.Task6.V14.Lib;

namespace Tyuiu.NasyrovaVR.Sprint4.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var week = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            string[] res = ds.Calculate(week);
            string[] wait = { "Январь", "Февраль", "Март", "Апрель", "Июнь", "Июль" };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
