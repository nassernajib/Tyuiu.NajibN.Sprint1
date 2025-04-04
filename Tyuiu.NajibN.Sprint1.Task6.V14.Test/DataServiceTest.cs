using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NajibN.Sprint1.Task6.V14.Lib;
namespace Tyuiu.NajibN.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "А Б A B a b а б";
            DataService ds = new DataService();
            bool res = ds.CheckLowerCaseRusLetters(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
            {
            }
        }
    }
}
