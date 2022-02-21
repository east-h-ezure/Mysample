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
            //インスタンスプロパティとインスタンスメソッド
            var date = new DateTime(2019, 10, 8);
            var year = date.Year;
            var month = date.Month;
            var day = date.Day;
            var date1 = date.AddDays(1);
            Console.WriteLine($"{year}年{month}月{day}日");
            Console.WriteLine(date1);

            //静的メソッド→インスタンスを生成せずに利用できるメソッド(ここでいうIsLeapYear)
            //Console.ReadLine, int.Parseも静的メソッドである
            var isLeapYear = DateTime.IsLeapYear(2020);
            if (isLeapYear)
            {
                Console.WriteLine("うるう年です");
            }
            else
            {
                Console.WriteLine("うるう年ではありません");
            }

            var book1 = new Book
            {
                Title = "伊豆の踊子",
                Author = "川端康成",
            };
            book1.PrintTitle();
            var book2 = new Book
            {
                Title = "走れメロス",
                Author = "太宰治",
            };
            book2.PrintTitle();
            var book3 = new Book
            {
                Title = "銀河鉄道の夜",
                Author = "宮沢賢治",
            };
            book3.PrintTitle();
            Book.ClearCount();
            Console.WriteLine(Book.Count);

            //静的クラス
            var scores = new int[] { 55, 60, 45, 70, 85, 93, 68 };
            var total = ArrayUtils.Total(scores);
            var average = ArrayUtils.Average(scores);
            Console.WriteLine($"合計：{total}, 平均：{average}");
            var max = ArrayUtils.Max(scores);
            var min = ArrayUtils.Min(scores);
            Console.WriteLine($"配列の最大値は{max}です");
            Console.WriteLine($"配列の最小値は{min}です");

        }
        class Book
        {
            public static int Count { get; set; }

            //静的メソッド→インスタンスを生成しなくても利用できるメソッド
            public static void ClearCount()
            {
                Count = 0;
            }
            public string Title { get; set;  }
            public string Author { get; set;  }
            public void PrintTitle()
            {
                Console.WriteLine($"書籍名：{Title}");
                Count++;
                Console.WriteLine(Count);
            }
        }

        static class ArrayUtils
        {
            public static int Total(int[] numbers)
            {
                var total = 0;
                foreach (var n in numbers)
                {
                    total += n;
                }
                return total;
            }

            public static double Average(int[] numbers)
            {
                var total = Total(numbers);
                return (double)total / numbers.Length;
            }

            public static int Max(int[] numbers)
            {
                return numbers.Max();
            }
            public static int Min(int[] numbers)
            {
                return numbers.Min();
            }
        }

    }
}
