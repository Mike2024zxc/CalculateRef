﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateRef
{
    class CalculateVIP : ICalcAccount
    {
        public void CalculateInterest(Account account)
        {
            // Расчет процентной ставк vip аккаунта по правилам банка
            account.Interest = account.Balance * 0.7;

        }
    }
}
