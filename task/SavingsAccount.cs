using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class SavingsAccount : Account 
    {
        public SavingsAccount(string Name = "Unnamed Account", double Balance = 0.0 , double interestRate= 0.0) : base(Name , Balance) 
        {
            InterestRate = interestRate;
        }
        public double InterestRate { get; private set; }

        

    }
}
