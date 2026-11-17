// Úloha 30: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Pocet poloziek: 2
//   Spolu: 5 EUR

List<Product> cart = new List<Product>();

Product bread = new Product { Name = "Chlieb", Price = 3 };
Product milk = new Product { Name = "Mlieko", Price = 2 };

cart.Add(bread);

int total = 0;
foreach (Product p in cart)
{
    total = total + p.Price;
}
Console.WriteLine("Pocet poloziek: " + cart.Count);
Console.WriteLine("Spolu: " + total + " EUR");

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}
