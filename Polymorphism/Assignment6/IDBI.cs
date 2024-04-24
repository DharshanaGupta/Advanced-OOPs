using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment6
{
    public class IDBI:Bank
    {
        public override void GetIntresetInfo()
        {
            Console.WriteLine("IDBI interest : 7.5%");
        }
    }
}