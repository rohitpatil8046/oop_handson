using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_handson
{
    class program
    {
        abstract class animal
        {
            public abstract void eat();
            public void sound()
            {
                Console.WriteLine("dog can sound");
            }
        }
        class dog : animal
        {
            public override void eat()
            {
                Console.WriteLine("dog can eat");
            }
        }
        static void Main(string[] args)
        {
            dog mydog = new dog();
            animal thePet = mydog;
            thePet.eat();
            mydog.sound();
            Console.ReadLine();
        }
    }
}