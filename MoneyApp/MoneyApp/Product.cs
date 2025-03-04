using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MoneyApp;

class Product : Money
{
    public string? Name { get; set; }
    private decimal promotion;
    
     
    public Product(string? name, int amountWhole, byte amountCents, decimal promotion) : base(amountWhole, amountCents)
    {
        Name = name;
        Promotion = promotion;
        
    }
    public decimal Promotion
    {
        get { return promotion; }
        set
        {
            if (value > 0 && value < 100)
                promotion = value / 100;
            else
                throw new Exception("Promotion cannot be less than 0 or more than 100");
        }
    }
    public void PriceWithPromotion()
    {
        decimal price = AmountWhole + AmountCents / 100m;
        decimal priceWithPromotion = price * (1 - promotion);
        Console.WriteLine($"Price with promotion: {priceWithPromotion:F2} dollars");
    }
}
