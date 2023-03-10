﻿using FixedDepositryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICICIConsoleApp.Models
{
    public class QuaterOneRatePolicy:IFixedDepositeRatePolicy
    {
        public double CalculateRate()
        {
            return 10.5;
        }
    }
}
