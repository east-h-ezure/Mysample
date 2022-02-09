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

            //代入演算子
            var num = 8;
            num += 2;
            Console.WriteLine(num);
            num *= 4;
            Console.WriteLine(num);

            //演算子による型変換
            var source = 15.8;
            var width2 = (int)source;
            Console.WriteLine(width2);

            var total2 = 998;
            var discount2 =(int) (total2 * 0.1);
            var payment = total2 - discount2;
            Console.WriteLine("割引額：{0}円", discount2);

            //文字列型を数値型に変換
            //ReadLineは文字列型
            var total3 = 100;
            Console.WriteLine("数値を入力してください");
            var line = Console.ReadLine();
            var count5 = int.Parse(line); //double.Parseなどを用いて、少数にすることもできる
            var num2 = total3 / count5;
            Console.WriteLine(num2);

            var name5 = "渡辺";
            var message2 = name5 + "さん、おはようございます！";
            Console.WriteLine(message2);
          
            //文字列の連結
            var msg = "こんにちは、";
            msg += "今日はいい天気ですね";
            Console.WriteLine(msg);

            //文字列と数字の連結
            var season = "夏";
            var tempareture = 39;
            var section = "今年の" + season + "は" + tempareture + "です。";
            Console.WriteLine(section);
            var section2 = $"今年の{season}の最高気温は、{tempareture}です。ひえー"; 
            Console.WriteLine(section2);
            Console.WriteLine($"ちなみに去年の{season}の最高気温は{tempareture + 2}度だったよ");

            //演習３
            var price2 = 1694;
            var tax = (int)(price2 * 0.08);
            Console.WriteLine($"税抜き{price2}円の商品の税込み価格は、{price2 + tax}円です。");
            var n1 = 100;                  //100 int     //!
            var n2 = 13;                    //13 int       //
            var a1 = n1 + n2;            //113 int    //
            var a2 = -n1 / n2;            //-7.692 double  -7
            var a3 = (double)n1 / n2;//7.892 double //
            var a4 = a2 - n1;              //-107.692 double  -107
            var a5 = a3 * -2;              //-15.38 double //
            var a6 = a4 * 2.0M;         //-215384..... double // 
            Console.WriteLine($"{n1}\n{n2}\n{a1}\n{a2}\n{a3}\n{a4}\n{a5}\n{a6}");

            //if文
            Console.WriteLine("数字を入力してください");
            var line2 = Console.ReadLine();
            var num6 = int.Parse(line2);
            if (num6 == 10)
            {
                Console.WriteLine("10が入力されました！");
            }
            else
            {
                Console.WriteLine("10以外の数字を入力しましたね？");
            }
            //演算子 or→|| and→&& ノットイコール→!=


            //switch文
            Console.WriteLine("ご希望の時間帯の番号を選択してください");
            Console.WriteLine("1: 10時から12時");
            Console.WriteLine("2: 13時から15時");
            Console.WriteLine("3: 15時から18時");
            var line3 = Console.ReadLine();
            var value3 = int.Parse(line3);
            switch (value3)
            {
                case 1:
                    Console.WriteLine("10時から12時がご希望ですね");
                    break;
                case 2:
                    Console.WriteLine("13時から15時がご希望ですね");
                    break;
                case 3:
                    Console.WriteLine("15時から17時がご希望ですね");
                    break;
                default:
                    Console.WriteLine("入力した値に誤りがあります");
                    break;
            }


            //演習４
            Console.WriteLine("空文字か文字を入力してください");
            var line4 = Console.ReadLine();
            if (line4 == "")
                {
                Console.WriteLine("空文字列です");
            }
            else
            {
                Console.WriteLine("文字を入力しましたね？");
            }
            Console.WriteLine("正の数か負の数、または0を入力してください");
            var line5 = Console.ReadLine();
            var value4 = int.Parse(line5);
            if (value4 == 0)
            {
                Console.WriteLine("0を入力しましたね？");
            }
            else if (value4 > 0)
            {
                Console.WriteLine("正の数を入力しましたね？");
            }
            else
            {
                Console.WriteLine("負の数を入力しましたね？");
            }

            Console.WriteLine("テストの点数を教えてください。成績を付けます");
            var line6 = Console.ReadLine();
            var value5 = int.Parse(line6);
            if (value5 >= 0 && value5 <= 30)
            {
                Console.WriteLine("不可");
            }
            else if (value5 > 30 && value5 <= 60)
            {
                Console.WriteLine("可");
            }
            else if (value5 > 60 && value5 <= 80)
            {
                Console.WriteLine("良");
            }
            else if (value5 > 80 && value5 <= 100)
            {
                Console.WriteLine("優");
            }
            else
            {
                Console.WriteLine("入力した点数に誤りがあります");
            }

            //繰り返し距離
            var year = 1;
            while (year <= 64)
            {
                var westernYear = year + 1925;
                Console.WriteLine($"昭和{year}年は西{westernYear}暦年です");
                year ++;
            }


        }
    }
}
