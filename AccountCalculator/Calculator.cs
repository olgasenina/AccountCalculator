using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCalculator
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки

        public static void CalculateInterest(ICalculateInterest calculateInterest, Account account)
        {
            calculateInterest.Execute(account);
        }
    }
}
