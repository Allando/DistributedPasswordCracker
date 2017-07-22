using ControlCenter.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCenter
{
    class Splitter
    {
        /*public string DictionaryPath { get; set; }
        //public string PasswordPath { get; set; }

        public Splitter(string dictionaryPath)
        {
            DictionaryPath = dictionaryPath;
            //PasswordPath = passwordPath;
        }*/

        List<string> DictList = new List<string>();

        public void RunSplitter(string dictPath)
        {
            Console.WriteLine("[*] Loading dictionary");

            List<UserInfoClearText> result = new List<UserInfoClearText>();

            using (FileStream fs = new FileStream(dictPath, FileMode.Open, FileAccess.Read))

            using (StreamReader dictionary = new StreamReader(fs))
            {
                while (!dictionary.EndOfStream)
                {
                    String dictionaryEntry = dictionary.ReadLine();
                    DictList.Add(dictionaryEntry);
                }
            }

            foreach (var i in DictList)
            {
                Console.WriteLine(i);
            }
        }

        

        //public static IEnumerable<List<T>> splitList<T>(List<T> locations, int nSize = 30)
        //{
        //    for (int i = 0; i < locations.Count; i += nSize)
        //    {
        //        yield return locations.GetRange(i, Math.Min(nSize, locations.Count - i));
        //    }
        //}
    }
}
