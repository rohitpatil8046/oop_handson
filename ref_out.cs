﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class Program
    {
        public static void update(out int a)
        {
            a = 10;
        }
        public static void change(ref int d)
        {
            d = 11;
        }
        static void Main(string[] args)
        {

            int b;
            int c = 9;
            Program p1 = new Program();
            update(out b);
            change(ref c);
            Console.WriteLine("Updated value is: {0}", b);
            Console.WriteLine("Changed value is: {0}", c);
            Console.ReadLine();

        }

         
    }
       
}






