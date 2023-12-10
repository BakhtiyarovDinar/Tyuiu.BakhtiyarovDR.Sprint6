using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.BakhtiyarovDR.Sprint6.Task6.V20.Libb
{
    public class DataService : ISprint6Task6V20
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    if (words.Length >= 2)
                    {
                        resStr += words[1] + " ";
                    }
                }
                return resStr;
            }
        }
    }
}
