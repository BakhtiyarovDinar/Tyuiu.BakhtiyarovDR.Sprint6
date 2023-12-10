using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BakhtiyarovDR.Sprint6.Task6.V20.Libb;

namespace Tyuiu.BakhtiyarovDR.Sprint6.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCollectTextFromFileValid()
        {
            string path = @"C:\Users\Dinar\source\repos\Tyuiu.BakhtiyarovDR.Sprint6\Tyuiu.BakhtiyarovDR.Sprint6.Task6.V20\bin\Debug\InPutFileTask6V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait1 = true;
            Assert.AreEqual(wait1, fileExists);
        }
    }
}
