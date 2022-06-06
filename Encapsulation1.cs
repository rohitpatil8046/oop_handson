using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_handson
{
    public class Bank
    {
        private double balance;
        public double getBalance()
        { 
            return balance;
        }
        public void setBalance(double balance)
        {
            this.balance = balance;
        }
    }
    class BankUser
    {
        public static void Main()
        {
            Bank SBI = new Bank();
            SBI.setBalance(500);
            Console.WriteLine(SBI.getBalance());
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}