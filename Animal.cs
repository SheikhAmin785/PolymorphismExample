using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("animal eat");
        }
        class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("eating meat");
            }
            class Cow : Animal
            {
                public override void Eat()
                {
                    Console.WriteLine("eating grass");
                }


            }
            static void AnimalMain()
            {
                Animal obj = new Dog();
                Animal obj1 = new Cow();
                obj.Eat();
                obj1.Eat();


            }
        }
    }
}
