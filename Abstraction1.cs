using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_handson
{
    abstract class Language
    {
        public void display()
        {
            Console.WriteLine("Non abstract method");
        }
    }

   
    class Program : Language
    {

        static void Main(string[] args)
        {

            Program obj = new Program();

            obj.display();

            Console.ReadLine();
        }
    }
}