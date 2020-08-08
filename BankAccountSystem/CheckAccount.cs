using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{

    public class CheckAccount : Account
    {
        public decimal FeeAmount { get; set; }
        public CheckAccount(decimal initialBalance, decimal feeamount) : base(initialBalance)
        {
            FeeAmount = feeamount;
        }
        public override bool Debit(decimal withdrawCash)
        {
            decimal balance = GetCurrentBalance();
            if (withdrawCash < balance)
            {
                balance = balance - withdrawCash - FeeAmount;
                GetCurrentBalance();
                return true;
            }
            else
            {
                Console.WriteLine("Debit Amount exceeded Account Balance!!");
                return false;
            }

        }
    }
}

