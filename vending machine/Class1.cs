using System;
using System.Collections.Generic;
using System.Text;

namespace vendingmachine
{
    class vendingmachine
    {
        private int depositedAmount;

        public vendingmachine()
        {
            depositedAmount = 0;
        }
    public void Depositcoin(int coinamount)
    {

        depositedAmount += coinamount;

    }
    public void Getdrink()
    {
        if (depositedAmount >= COST_OF_DRINK)
        {
            Console.WriteLine("Your change is {0} cents", depositedAmount - COST_OF_DRINK);
                depositedAmount = 0;
        }
        else
            Console.WriteLine("insert more coin");
    }

    public void GetRefund()
    {
        Console.WriteLine("You were refunded {0}", depositedAmount);
            depositedAmount = 0;
    }

    }
}
