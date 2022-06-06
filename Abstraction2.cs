﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_handson
{
    abstract class Animal
    {
        public abstract void makeSound();
    }

    class Dog : Animal
    { 
        public override void makeSound()
        {

            Console.WriteLine("Bark Bark");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.makeSound();

            Console.ReadLine();
        }
    }
}