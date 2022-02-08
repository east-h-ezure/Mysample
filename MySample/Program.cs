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


        }
    }
}
