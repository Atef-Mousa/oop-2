using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class TrustAccount : Account
    {

        public int WithdrawlNumber { get; private set; } = 0; 
        public double InterestRate { get; set; }

        public TrustAccount(string Name = "Unnamed Account", double Balance = 0.0 ,double interestRate =0.0 ) : base(Name : Name , Balance:Balance) 
        {
            InterestRate = interestRate; 
        }

        public override bool Deposit(double amount)
        {
            if (amount > 5000)
                return base.Deposit(amount + 50); 
            return base.Deposit(amount);
        }

        public override bool Withdraw(double amount)
        {
            if(WithdrawlNumber>3 || amount > Balance*0.2)
                return false;

            WithdrawlNumber++; 

            return base.Withdraw(amount);
        }

        
    }
}
