using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NajibN.Sprint1.Task5.V2.Lib;
namespace Tyuiu.NajibN.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFahrenheitToСelsius()
        {
            DataService ds = new DataService();
            double temp = 38;
            var res = ds.FahrenheitToСelsius(temp);
            Assert.AreEqual(3, res);
            {
            }
        }
    }
}
