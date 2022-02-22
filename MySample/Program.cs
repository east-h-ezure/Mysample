using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    class Program
     //ポリモーフィズム
    {
        static void Main(string[] args)
        {
            var pet1 = new FoodiePet("エイミー");
            pet1.Play();
            pet1.Eat();
            pet1.Sleep();
            Console.WriteLine($"{pet1.Name} 機嫌:{pet1.Mood} エネルギー:{pet1.Energy}");

            var pet2 = new CheerfulPet("クー");
            pet2.Play();
            pet2.Eat();
            pet2.Sleep();
            Console.WriteLine($"{pet2.Name} 機嫌:{pet2.Mood} エネルギー:{pet2.Energy}");

            var pet3 = new SleepyPet("ライアン");
            pet3.Play();
            pet3.Eat();
            pet3.Sleep();
            Console.WriteLine($"{pet3.Name} 機嫌:{pet3.Mood} エネルギー:{pet3.Energy}");
        }

        class VirtualPet
        {
            public string Name { get; private set; }
            public int Mood { get; set; }
            public int Energy { get; set; }
            public VirtualPet(string name)
            {
                Name = name;
                Mood = 5;
                Energy = 100;
            }

            public virtual void Eat()
            {

            }
            public virtual void Play()
            {

            }
            public virtual void Sleep()
            {

            }

            //派生クラスを定義する
            class FoodiePet : VirtualPet
            {
                public FoodiePet(string name) : base(name)
                {

                }
                public override void Eat()
                {
                    Mood += 3;
                    Energy += 6;
                    Console.WriteLine("Foodie.Eatメソッドが実行されました");
                }
                public override void Play()
                {
                    Mood -= 1;
                    Energy -= 10;
                    Console.WriteLine("Foodie.Playメソッドが実行されました");
                }
                public override void Sleep()
                {
                    Mood -= 1;
                    Energy += 2;
                    Console.WriteLine("Foodie.Sleepメソッドが実行されました");
                }
            }

            class CheefulPet : VirtualPet
            {
                public CheerfulPet(string name) : base(name)
                {

                }
                public override void Eat()
                {
                    Mood += 0;
                    Energy += 5;
                    Console.WriteLine("Foodie.Eatメソッドが実行されました");
                }
                public override void Play()
                {
                    Mood -= 3;
                    Energy -= 10;
                    Console.WriteLine("Foodie.Playメソッドが実行されました");
                }
                public override void Sleep()
                {
                    Mood -= 1;
                    Energy += 2;
                    Console.WriteLine("Foodie.Sleepメソッドが実行されました");
                }
            }

            class SleepyPet : VirtualPet
            {
                public FoodiePet(string name) : base(name)
                {

                }
                public override void Eat()
                {
                    Mood -= 1;
                    Energy += 5;
                    Console.WriteLine("Foodie.Eatメソッドが実行されました");
                }
                public override void Play()
                {
                    Mood -= 1;
                    Energy -= 10;
                    Console.WriteLine("Foodie.Playメソッドが実行されました");
                }
                public override void Sleep()
                {
                    Mood += 2;
                    Energy += 2;
                    Console.WriteLine("Foodie.Sleepメソッドが実行されました");
                }
            }
        }

    }
}
