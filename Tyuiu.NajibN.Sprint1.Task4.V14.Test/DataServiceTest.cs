﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NajibN.Sprint1.Task4.V14.Lib;
namespace Tyuiu.NajibN.Sprint1.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double wait = 0.062;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
            {
            }
        }
    }
}
