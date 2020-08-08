using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    public  class Account
    {
        private decimal AccountBalance;
        public decimal InitialBalnce { get; set; }
        public Account(decimal initialBalance)
        {
            if(initialBalance>=0)
            {
                InitialBalnce = initialBalance;
              this.AccountBalance = InitialBalnce;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public bool Credit(decimal AddAmount)
        {       
             AccountBalance = AccountBalance + AddAmount;
            return true;
        }
        public virtual bool  Debit(decimal withdrawCash)
        {
           
            if(withdrawCash<AccountBalance)
            {
                AccountBalance = AccountBalance - withdrawCash;

                return true;
            } 
            else
            {
                Console.WriteLine("Debit Amount exceeded Account Balance!!");
                return false;
            }
                       
        }      
        public  decimal GetCurrentBalance()
        {
            return AccountBalance;   
        }
        

    }
}
