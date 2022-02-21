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
        //クラスリストとLINQ
        //リストと配列の使い開け
        //通常はリストを使う、要素の追加削除などを行わない場合は配列をつかうといい
        {
            var lines = new List<string>
            {
                "おはよう",
                "こんにちは",
                "こんばんは"
            };
            lines.Add("おやすみ");
            lines.Add("さようなら");
            /*            foreach (var s in lines)
                        {
                            Console.WriteLine(s);
                        }*/

            var messages = lines;
            messages.RemoveAt(2);
            foreach (var t in messages)
            {
                Console.WriteLine(t);
            }
            var count = messages.Count;
            Console.WriteLine($"要素数：{count}");

        }
        class book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Pages { get; set; }
            public int Rating { get; set; }
            public Book(string title, string author, int pages, int rating)
            {
                Title = title;
                Author = author;
                Pages = pages;
                Rating = rating;
            }
        }
    }
}
