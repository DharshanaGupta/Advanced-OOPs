using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public interface IBalance
    {
        double WalletBalance{get;}

        double WalletRecharge(double amount);
        double DeductBalance(double amount);
    }
}