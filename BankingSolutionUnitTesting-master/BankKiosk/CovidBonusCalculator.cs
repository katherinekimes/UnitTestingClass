﻿using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKiosk
{
    public class CovidBonusCalculator : ICalculateAccountBonuses
    {
        decimal ICalculateAccountBonuses.GetDepositBonusFor(decimal balance, decimal amountToDeposit)
        {
            return amountToDeposit * .35m;
        }
    }
}
