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
            var dates = new List<DateTime>
            {
                new DateTime(2019,12, 9, 8,15, 0),
                new DateTime(2020, 8, 4,23, 6, 0),
                new DateTime(2010, 4, 5, 8, 1, 0),
                new DateTime(2018,12,12,10,13, 0),
                new DateTime(2016, 3,18,15,35, 0),
                new DateTime(2014, 4, 1,18,46, 0),
            };
            var count = dates.Count();
            Console.WriteLine(count);

            var books = new List<Book>();
            books.Add(new Book("人間失格", "太宰治", 212, 5));
            books.Add(new Book("吾輩は猫である", "夏目漱石", 610, 4));
            books.Add(new Book("女生徒", "太宰治", 279, 4));
            books.Add(new Book("銀河鉄道の夜", "宮沢賢治", 357, 3));
            books.Add(new Book("伊豆の踊子", "川端康成", 201, 3));
            books.Add(new Book("こゝろ", "夏目漱石", 378, 5));
        
            var query = books.Where(x => x.Rating >= 4);
            foreach (var book in query)
            {
                Console.WriteLine($"{book.Title} {book.Author}");
            }
            Console.WriteLine("タイトル名で並べ替え");
            var orderby = books.OrderBy(x => x.Title);
            foreach (var book2 in orderby)
            {
                Console.WriteLine($"{book2.Title} {book2.Author}");
            }
        }

        class Book
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
