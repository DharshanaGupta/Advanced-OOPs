using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagemnet
{
    public interface IBalance
    {
        double Balance{get;set;}

        double WalletRecharge(double amount);
        double DeductBalance(double amount);
    }
}