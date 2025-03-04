namespace MoneyApp;

internal class Program
{
    static void Main(string[] args)
    {
        Money m = new Money(100, 150);
        m.ShowAmount();
        Product product = new Product("Phone", m,  25);
        product.PriceWithPromotion();
    }
}
