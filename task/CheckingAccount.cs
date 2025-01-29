using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class CheckingAccount : Account
    {
        public CheckingAccount(string Name = "Unnamed Account", double Balance = 0.0 ) : base(Name,Balance ) { }

        public double FlatFee { get; private set; } = 1.50;

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount+FlatFee);
        }
    }
}
