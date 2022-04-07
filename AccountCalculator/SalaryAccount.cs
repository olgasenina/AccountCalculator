using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCalculator
{
    /// <summary>
    /// Расчет процентной ставк зарплатного счета по правилам банка
    /// </summary>
    public class SalaryAccount : ICalculateInterest
    {
        public void Execute(Account account)
        {
            Console.WriteLine("Расчет процентной ставки для зарплатного счета");
            account.Interest = account.Balance * 0.5;
        }
    }
}
