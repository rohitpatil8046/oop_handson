﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_handson
{
    class Shape 
    {
      public void setWidth(int w) 
      {
         width = w;
      }

      public void setHeight(int h) 
      {
         height = h;
      }

      protected int width;
      protected int height;
    }
      class Rectangle: Shape 
      {
         public int getArea() 
         {
         return (width * height);
         }
      }
 }
      class RectangleTester {
      static void Main(string[] args) {
         Rectangle Rect = new Rectangle();
   
         Rect.setWidth(5);
         Rect.setHeight(7);
         Console.WriteLine("Total area: {0}", Rect.getArea());
         Console.ReadKey();
      }
   }
}