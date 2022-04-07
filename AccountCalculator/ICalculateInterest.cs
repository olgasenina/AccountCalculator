using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCalculator
{
    /// <summary>
    /// Интерфейс расчета процентной ставки
    /// </summary>
    public interface ICalculateInterest
    {
        void Execute(Account account);
    }
}
