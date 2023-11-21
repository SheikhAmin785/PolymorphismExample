using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class OverloadingUsingdollersign
    {
        public void show(string str)
        {
            Console.WriteLine(str);
        }
        public void show(string str1,string str2)
        {
            Console.WriteLine($"{str1},{str2}");
        }
        public void show(string str1,string str2,string str3)
        {
            Console.WriteLine($"{str1},{str2},{str3}");
        }
        public void show(int a)
        {
            Console.WriteLine($"integer{a}");
        }
        public static void Main()
        {
            OverloadingUsingdollersign obj = new OverloadingUsingdollersign();
            obj.show("hello world");
            obj.show(1, "john");
        }

        }
    }
}
