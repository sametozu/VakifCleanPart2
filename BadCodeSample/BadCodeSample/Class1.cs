﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeSample
{
   public class Class1
    {
        public decimal Calculate(decimal amount, int type, int years)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
            if (type == 1)
            {
                result = amount;
            }
            else if (type ==2)
            {
                result = amount - (0.1m * amount) - disc * (amount - (0.1m * amount));
            }
            else if (type==3)
            {
                result = amount - (0.3m * amount) - disc * (amount - (0.3m * amount));

            }
            else if (type==4)
            {
                result = amount - (0.5m * amount) - disc * (amount - (0.5m * amount));

            }
            return result;
        }
    }
}
