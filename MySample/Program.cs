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
            //オブジェクトの生成(Bookクラスからインスタンスを作成)
            //プログラムでBookクラスを使うには
            //var 変数名 = new クラス名();

            var book1 = new Book
            {
                //プロパティへの値の代入
                Title = "吾輩は猫である",
                Author = "夏目漱石",
                Pages = 610,
                Rating = 4,
            };

            var book2 = new Book
            {
                Title = "人間失格",
                Author = "夏目漱石",
                Pages = 610,
                Rating = 5,
            };

            Console.WriteLine("Printメソッドを呼び出します。");
            //Printメソッドの呼び出し
            book1.Print();
            book2.Print();
            Console.WriteLine("Printメソッドの処理が終わりました");

            var sale = new Sale
            {
                ProductName = "おにぎり",
                UnitPrice = 120,
                Quantity = 4
            };
            var amount = sale.GetAmount();
            Console.WriteLine($"合計金額：{amount}円");

            //引数の呼び出し
            var bmicalc = new BmiCalculator();
            var bmi = bmicalc.GetBmi(162, 53);
            Console.WriteLine( $"BMI: {bmi}");
            var type = bmicalc.GetBodyType(bmi);
            Console.WriteLine($"あなたは「{type}」です。");
        }

        class Book
        {
            //プロパティの追加
            public string Title { get; set; }
            public string Author { get; set; }
            public int Pages { get; set; }
            public int Rating { get; set; }

            //メソッドの定義
            //public修飾子をつかうことで、Bookクラスの外側から利用できるようになる
            //メソッド名の頭文字は大文字推奨
            public void Print()
            {
                //thisを省略できる
                Console.WriteLine($"{Title}");
                Console.WriteLine($"{this.Author} {this.Pages}ページ 評価：{this.Rating}");
            }
        }
        
        //戻り値のあるメソッドの使い方
        class Sale
        {
            public string ProductName { get; set;  }
            public int UnitPrice { get; set;  }
            public int Quantity { get; set;  }
            public int GetAmount()
            {
                return  UnitPrice * Quantity;
          
            }
        }

        //引数のあるメソッド
        class BmiCalculator
        {
                                                                       //↓引数 
            public double  GetBmi (int height, int weight)
            {
                var metersTall = height / 100.0;
                var bmi = weight / (metersTall * metersTall);
                return bmi;
            }

            public string GetBodyType(double bmi)
            {
                var type = "";
                    if (bmi < 18.5)
                {
                    type = "瘦せ型";
                }
                else if(bmi < 25)
                {
                    type = "標準体重";
                }
                else if (bmi < 25)
                {
                    type = "肥満度１";
                }
                else if(bmi < 30)
                {
                    type = "肥満度2";
                }
                else if(bmi < 35)
                {
                    type = "肥満度3";
                }
                else 
                {
                    type = "肥満度4";
                }
                return type;
            }
        }

    }
}
