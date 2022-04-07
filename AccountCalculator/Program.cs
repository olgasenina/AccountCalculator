using System;

namespace AccountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Обычный счет
            Account account = new Account();
            account.Type = "Обычный";
            account.Balance = 900000;

            Console.WriteLine("");

            Calculator.CalculateInterest(new RegularAccount(), account);

            Console.WriteLine($"Balance = {account.Balance}; Interest = {account.Interest}");

            // Зарплатный счет
            Account account2 = new Account();
            account2.Type = "Зарплатный";
            account2.Balance = 50000;

            Console.WriteLine("");

            Calculator.CalculateInterest(new SalaryAccount(), account2);

            Console.WriteLine($"Balance = {account2.Balance}; Interest = {account2.Interest}");


            Console.ReadKey();
        }
    }
}
