using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp;

class Product : Money
{
    public string? Name { get; set; }
    private byte promotion;
    
     
    public Product(string? name, int amountWhole, byte amountCents, byte promotion) : base(amountWhole, amountCents)
    {
        Name = name;
        this.promotion = promotion;
        
    }
    public byte Promotion
    {
        get { return promotion; }
        set
        {
            if (value > 0 && value < 100)
                promotion = value;
            else
                throw new Exception("Promotion cannot be less than 0 or more than 100");
        }
    }
    public void PriceWithPromotion()
    {

    }
}
