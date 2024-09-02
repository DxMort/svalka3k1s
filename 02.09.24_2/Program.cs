using System.Xml.Linq;
public abstract class Product
{
    int discount = 10;
    public virtual int Price { get; set; }
    public virtual string Name { get; set; }
    public abstract string GetInformation();
    public string GetDiscountedPrice()
    {
        return $"Price with discount: {Price - Price * discount/100}";
    }

}
public class Toy : Product
{
    public string color;
    public override string GetInformation()
    {
        return $"{Name} (Toy), color: {color}, Price: {Price}";
    }
}
public class Meat : Product
{
    public string type;
    public override string GetInformation()
    {
        return $"{Name} (Meat), type: {type}, Price: {Price}";
    }
}
public class Drinks : Product
{
    public double volume;
    public override string GetInformation()
    {
        return $"{Name} (Drinks), type: {volume}, Price: {Price}";
    }
}
public class IceCream : Product
{
    public string shape;
    public override string GetInformation()
    {
        return $"{Name} (IceCream), shape: {shape}, Price: {Price}";
    }
}
public class Sauce : Product
{
    public string flavor;
    public override string GetInformation()
    {
        return $"{Name} (Sauce), flavor: {flavor}, Price: {Price}";
    }
}
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Toy { Name = "Ball", color = "yellow" , Price = 70 },
            new Meat { Name = "Chicken", type = "frozen", Price = 300},
            new Drinks { Name = "Monster Energy Ultra", volume = 0.5, Price = 250},
            new IceCream { Name = "Grospirone", shape = "eskimo", Price = 60 },
            new Sauce { Name = "Ketchup", flavor = "tomato", Price = 159 }
        };
        foreach (Product product in products)
        {
            Console.WriteLine(product.GetInformation() + " " + product.GetDiscountedPrice());
            
        }
    }
}
