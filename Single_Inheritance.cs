using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_handson
{
     class car
    {
        protected String model;
        protected string color;
        protected int price;

        protected void printcarinformation()
        {
            Console.WriteLine("model:" + model);
            Console.WriteLine("color:" + color);
            Console.WriteLine("pice:" + price);
        }
        class suzuki:car
        {
            public float speed;
           public void PrintMileage()
            {
                Console.WriteLine("Speed:"+speed);
            }
        }

        static void Main(string[] args)
        {
            suzuki mycar = new suzuki();
            mycar.model = "Farrari";
            mycar.color = "Black";
            mycar.price = 2000000;
            mycar.speed = 22.7f;
            mycar.printcarinformation();
            mycar.PrintMileage();
            Console.ReadLine();
        }
    }
}
