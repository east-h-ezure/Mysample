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
            var book = new Book
            {
                Title = "吾輩は猫である",
                Memo = "猫ちゃんが主人公の素晴らしい作品",
            };
            
            book.Print();

            var employee = new Employee
            {
                Id = 1,
                FamilyName = "本田",
                GivenName = "翼",
                EmailAddress = "tsubasa@gmail.com",
            };
            employee.Print2();
            Console.WriteLine(employee.GetFullName());

            
        }

        class Book
        {
            public string Title { get; set; }
            public string Memo { get; set; }
            
            public void Print()
            {
                Console.WriteLine($"タイトル：{Title}");
                Console.WriteLine($"概要：{Memo}");
            }
        }

        class Employee
        {
            public int Id { get; set;  }
            public string FamilyName { get; set; }
            public string GivenName { get; set;  }
            public string EmailAddress { get; set;  }

            public void Print2()
            {
                Console.WriteLine($"ID{Id}の従業員の名前は{FamilyName} {GivenName}です。");
                Console.WriteLine($"Emailアドレスは{EmailAddress}です");
            }

            public string GetFullName()
            {
                string FullName = FamilyName + GivenName;
                return FullName;
            }
        }

    }
}
