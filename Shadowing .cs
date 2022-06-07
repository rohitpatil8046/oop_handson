using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mymethods
{
    Public class BaseClass
{
    public string GetMethodOwnerName()
    {
       return "Base Class";
    }
}
public class ChildClass : BaseClass
{
    public new string GetMethodOwnerName()
    {
       return "ChildClass";
    }
}
    
        public static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
            Console.WriteLine(c.GetMethodOwnerName());
            Console.WriteLine();
        }
        
            
        
    }
}
