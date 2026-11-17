// ===== TRIEDY 08 – List objektov =====
// Pojmy: List<Product>, Add, Count, foreach, Remove, hľadanie najväčšieho
// Skús zmeniť:
//   1. Pridaj ďalší produkt.
//   2. Odstráň z listu mlieko (Remove).
//   3. Vypíš len produkty drahšie ako 2 eurá.

List<Product> cart = new List<Product>();
cart.Add(new Product { Name = "Chlieb", Price = 3 });
cart.Add(new Product { Name = "Mlieko", Price = 2 });
cart.Add(new Product { Name = "Syr", Price = 7 });

Console.WriteLine("Pocet poloziek: " + cart.Count);

int total = 0;
foreach (Product p in cart)
{
    Console.WriteLine(p.Name + " - " + p.Price + " EUR");
    total = total + p.Price;
}
Console.WriteLine("Spolu: " + total + " EUR");

Product mostExpensive = cart[0];
foreach (Product p in cart)
{
    if (p.Price > mostExpensive.Price)
    {
        mostExpensive = p;
    }
}
Console.WriteLine("Najdrahsie: " + mostExpensive.Name);

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}
