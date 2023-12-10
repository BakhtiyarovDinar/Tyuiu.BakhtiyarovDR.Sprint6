using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BakhtiyarovDR.Sprint6.Task7.V5.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint6.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\Dinar\source\repos\Tyuiu.BakhtiyarovDR.Sprint6\Tyuiu.BakhtiyarovDR.Sprint6.Task7.V5\bin\Debug\InPutFileTask7V5.csv";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
