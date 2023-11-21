using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    interface IAnimal
    {
        void Sound();
    }
    interface IFish
    {
        void Katla();
    }

    public class Cat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("cat sound is meow");
        }
    }
    public static void Imain()
    {
        Cat obj = new Cat();
        obj.Sound();

    }

}
