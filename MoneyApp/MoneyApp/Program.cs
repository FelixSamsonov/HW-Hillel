namespace MoneyApp;

internal class Program
{
    static void Main(string[] args)
    {
        Money m = new Money(100, 56);
        m.ShowAmount();
        Product product = new Product("Phone", 100, 56, 25);
        product.PriceWithPromotion();
    }
}
