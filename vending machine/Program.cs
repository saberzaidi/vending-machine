using System;

namespace vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendingmachine = new vendingmachine();
            vendingmachine.DepositCoin(100);
            vendingmachine.Getdrink();
            vendingmachine.GetRefund();
            Console.ReadLine();

        }
    }
}
