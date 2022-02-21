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
            //C#の方はすべて値型と参照型のどっちか
            //列挙型

            var week = DayOfWeek.Sunday;
            if (week == DayOfWeek.Friday)
            {
                Console.WriteLine("金曜日です");
            } else
            {
                Console.WriteLine("金曜日ではありません");
            }

           
        }



    }
}
