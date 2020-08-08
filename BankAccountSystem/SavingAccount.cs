using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{

    public class SavingAccount : Account
    {
        public decimal InterestRate { get; set; }
        public SavingAccount(decimal initialBalance, decimal interestrate) : base(initialBalance)
        {
            InterestRate = interestrate;
        }
        public decimal CalculateInterest()
        {
         
            InterestRate = InterestRate * GetCurrentBalance();
            return InterestRate;
        }

    }
}
