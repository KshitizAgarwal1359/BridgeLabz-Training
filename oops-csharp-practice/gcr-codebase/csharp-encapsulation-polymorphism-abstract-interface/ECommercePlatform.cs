using System;
using System.Collections.Generic;
interface ITaxable //defines tax related behavior
{
    double CalculateTax();
    string GetTaxDetails();
}
abstract class Product //base class for all products
{
    private int productId;
    private string name;
    private double price;
    public int ProductId
    {
        get{return productId;}
        private set
        {
            if(value<=0)
            throw new ArgumentException("Product ID must be positive");
            productId=value;
        }
    }
    public string Name
    {
        get{return name;}
        private set
        {
            if(string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("product name cannot be empty");
            name = value;
        }
    }
    public double Price
    {
        get{return price;}
        protected set
        {
            if(value<0)
            throw new ArgumentException("price cannot be negative");
            price = value;
        }
    }
    protected Product(int productId,string name,double price)
    {
        ProductId=productId;
        Name=name;
        Price = price;
    }
    public abstract double CalculateDiscount();
    public virtual void DisplayProduct()
    {
        Console.WriteLine($"ID: {ProductId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Base Price: {Price}");
    }
}
class Electronics : Product, ITaxable
{
    public Electronics(int id,string name,double price) : base(id,name,price){}
    public override double CalculateDiscount()
    {
        return Price*0.10; //10% discount
    }
    public double CalculateTax()
    {
        return Price*0.18; //18% gst
    }
    public string GetTaxDetails()
    {
        return "Electronics Tax: 18% gst";
    }
}
class Clothing : Product, ITaxable
{
    public Clothing(int id,string name,double price):base(id,name,price){}
    public override double CalculateDiscount()
    {
        return Price*0.20;
    }
    public double CalculateTax()
    {
        return Price*0.12;
    }
    public string GetTaxDetails()
    {
        return "Clothing Tax: 12% gst";
    }
}
class Groceries : Product
{
    public Groceries(int id,string name,double price):base(id,name,price){}
    public override double CalculateDiscount()
    {
        return Price*0.05;
    }
}
class ECommercePlatform
{
    static void CalculateFinalPrices(List<Product> products)
    {
        foreach(Product product in products)
        {
            double tax=0;
            if(product is ITaxable taxableProduct)
            {
                tax=taxableProduct.CalculateTax();
                Console.WriteLine(taxableProduct.GetTaxDetails());
            }
            double discount = product.CalculateDiscount();
            double finalPrice=product.Price+tax-discount;
            product.DisplayProduct();
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Final Price: {finalPrice}\n");
        }
    }
    public static void Main(String[] args)
    {
        List<Product> products = new List<Product>
        {
            new Electronics(234,"Smartphone",45000),
            new Clothing(321,"Shirt",2000),
            new Groceries(100,"Honey",567)
        };
        CalculateFinalPrices(products);
    }
}