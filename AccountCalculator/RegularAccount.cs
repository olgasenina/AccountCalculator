using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCalculator
{
    /// <summary>
    /// Расчет процентной ставки обычного счета по правилам банка
    /// </summary>
    public class RegularAccount : ICalculateInterest
    {
        public void Execute(Account account)
        {
            Console.WriteLine("Расчет процентной ставки для обычного счета");

            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance < 50000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}
