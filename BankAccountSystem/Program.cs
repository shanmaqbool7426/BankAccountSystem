using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(30000);
            a1.Credit(10000);
            
            a1.GetCurrentBalance();
            Console.ReadLine();
            SavingAccount s1 = new SavingAccount(5000,4);
            s1.CalculateInterest();
        }
    }
}
