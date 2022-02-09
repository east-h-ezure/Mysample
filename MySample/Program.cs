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
            //int 整数を扱うことができる変数の型
            int age;
            age = 23;
            int number = 9;
            Console.WriteLine("{0}歳の人は{1}人います", age, number);

            //文字列型string
            string name = "山田";
            Console.WriteLine("{0}さん、こんにちは", name);
            name = "剛田";
            Console.WriteLine("{0}さん、おひさしぶりです", name);

            //演算
            int height = 5;
            int width = 8;
            int area = height * width;
            Console.WriteLine("面積: {0}㎡", area);

            //varを用いた変数の初期化
            //REadLineは、キーボードからの入力を一行読み取る
            Console.WriteLine("名前を入力してください");
            var name2 = Console.ReadLine();
            Console.WriteLine("{0}さん、おはようございます", name2);

            //変数のつけ方
            //2つ以上の単語をつなげるときは、firstNameのように２番目以降の単語を大文字にする


            //整数はint型を推奨
            //少数はdouble型を推奨

            //エスケープシーケンス
            Console.WriteLine("おはよう\nこんにちは\nこんばんは");

            //文字列の長さ
            var message = "good morning";
            var length = message.Length;
            Console.WriteLine("{0}文字", length);

            //空文字列
            var emptyString = "";
            Console.WriteLine("一行目");
            Console.WriteLine(emptyString);
            Console.WriteLine("三行目");

            //文字型(not文字列型)
            //シングルクオーテーション
            char alphabet = 'A';
            Console.WriteLine(alphabet);

            //論理型
            bool exists = true;
            Console.WriteLine(exists);

            //2章演習
            var name3 = "山田";
            Console.WriteLine("{0}さん、こんにちは", name3);
            var name4 = "近藤";
            var age2 = 19;
            Console.WriteLine("{0}さんは今年で{1}歳になります", name4, age2);
            var kilometersPerHour = 54;
            var hour = 3;
            var kilometer = kilometersPerHour * hour;
            Console.WriteLine(kilometer);

        }
    }
}
