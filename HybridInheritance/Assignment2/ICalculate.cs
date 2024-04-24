using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface ICalculate
    {
        double Deposit();
        double Withdraw();
        void BalanceCheck();
        
    }
}