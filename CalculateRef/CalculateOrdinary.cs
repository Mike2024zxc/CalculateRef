using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateRef
{
    class CalculateOrdinary : ICalcAccount
    {
        public void CalculateInterest(Account account)
        {
            // Расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;


        }

    }
}
