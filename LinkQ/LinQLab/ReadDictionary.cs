using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQLab
{
    public static class ReadDictionary
    {
        public static string path = "D:\\iti\\c#\\LINQ AND Entity\\dictionary_english.txt";

        public static List<string> Names = [];

        static ReadDictionary()
        {
            Names = File.ReadAllLines(path).ToList();
        }


    }
}
