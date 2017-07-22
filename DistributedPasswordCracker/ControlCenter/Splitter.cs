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
        public string DictionaryPath { get; set; }
        public string PasswordPath { get; set; }

        

         RunSplitter()
        {
            Console.WriteLine("passwd opeend");

            List<UserInfoClearText> result = new List<UserInfoClearText>();

            using (FileStream fs = new FileStream("webster-dictionary.txt", FileMode.Open, FileAccess.Read))

            using (StreamReader dictionary = new StreamReader(fs))
            {
                while (!dictionary.EndOfStream)
                {
                    String dictionaryEntry = dictionary.ReadLine();

                }
            }
        }
    }
}
