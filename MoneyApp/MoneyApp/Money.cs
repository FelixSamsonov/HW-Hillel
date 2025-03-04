using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp;

class Money
{
    private int amountWhole;
    private byte amountCents;

    public Money(int amountWhole, byte amountCents)
    {
        this.amountWhole = amountWhole;
        this.amountCents = amountCents;
    }

    public int AmountWhole
    {
        get { return amountWhole; }
        set
        {
            if (value >= 0)
                amountWhole = value;
            else
                throw new Exception("Amount cannot be less than 0");
        }
    }
    public byte AmountCents
    {
        get { return amountCents; }
        set
        {
            if (value >= 0 && value < 101)
                amountCents = value;
            else
                throw new Exception("Cents cannot be less than 0 or more than 100");
        }
    }
     public void ShowAmount()
    {
        Console.WriteLine($"Your price: {AmountWhole} dollars {AmountCents} cents");
    }
}
