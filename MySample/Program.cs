using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new string[]
            {
                "祇園精舎の鐘",
                "沙羅双樹の花の色",
                "奢れる人も久しからず",
                "強きものもつひには滅びぬ"
            };
            string path = @"C:\\text.txt";
            File.WriteAllLines(path,  lines, Encoding.UTF8);
        }



    }
}
