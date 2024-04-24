using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeCardmanagement
{
    public interface IBalance
    {
        public double Walletbalance{get;set;}

        double WalletRecharge(double amount);
        public double DeductAmount(double amount);
    }
}