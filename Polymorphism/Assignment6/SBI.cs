using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment6
{
    public class SBI:Bank
    {
        public override void GetIntresetInfo()
        {
            Console.WriteLine("SBI interest : 7.5%");
        }
    }
}