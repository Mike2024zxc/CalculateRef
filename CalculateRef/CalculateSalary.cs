using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateRef
{
    class CalculateSalary : ICalcAccount
    {
        public void CalculateInterest(Account account)
        {
            // Расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;

        }
    }
}
