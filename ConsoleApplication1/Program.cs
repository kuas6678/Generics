using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 泛型 (generic) 是一種定義通用型態 (type) 的程式設計，這是用另定識別字 (identifier) 的方式，該識別字可以當作各種型態。泛型 (generic) 是一種定義通用型態 (type) 的程式設計，這是用另定識別字 (identifier) 的方式，該識別字可以當作各種型態。
            Record<string> score1 = new Record<string>("BMWLab", "A");
            Console.WriteLine("BMWLab " + score1.Getgrade());

            Record<int> score2 = new Record<int>("QQ", 123);
            Console.WriteLine("QQ " + score2.Getgrade());

            // 多識別字用法。
            Demo<string, string> d1 = new Demo<string, string>("Hello~", "ASP.NET.");
            d1.DoSomething();

            Demo<int, double> d2 = new Demo<int, double>(3121, 123.4);
            d2.DoSomething();
            Console.WriteLine(d2.GetStr());

            // 在 Method 達到泛型的效果。
            Console.WriteLine(Show<string>("Hello!"));

            Console.ReadKey();
        }

        // Record<T>後角括弧中的 T ， T 亦即通用型態的識別字
        public class Record<T>
        {
            private string _name;
            private T _grade;

            public Record(string name, T grade)
            {
                this._name = name;
                this._grade = grade;
            }

            public T Getgrade()
            {
                return this._grade;
            }
        }

        // 這樣的識別字也可以有多個，下例示範使用兩個識別字 T 及 U
        public class Demo<T, U>
        {
            private T a;
            private U b;

            public Demo(T p1, U p2)
            {
                a = p1;
                b = p2;
            }

            public void DoSomething()
            {
                System.Console.WriteLine("{0} {1}", a, b);
            }

            public U GetStr()
            {
                return this.b;
            }
        }

        static T Show<T>(T t)
        {
            T Result = t;
            return Result;
        }
    }
}
