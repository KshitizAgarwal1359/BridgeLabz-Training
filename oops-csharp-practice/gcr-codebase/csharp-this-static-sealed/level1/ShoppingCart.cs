using System;
class Product
{
    // static variable (shared discount for all products)
    public static double Discount = 10.0; // percentage
    public readonly int ProductID; // readonly variable (cannot be changed after assignment)
    public string ProductName; // instance variables
    public double Price;
    public int Quantity;
    public Product(int ProductID, string ProductName, double Price, int Quantity) // Constructor using 'this' keyword
    {
        this.ProductID = ProductID;
        this.ProductName = ProductName;
        this.Price = Price;
        this.Quantity = Quantity;
    }
    public static void UpdateDiscount(double newDiscount) // static method to update discount
    {
        if (newDiscount >= 0 && newDiscount <= 100)
        {
            Discount = newDiscount;
        }
        else
        {
            Console.WriteLine("Invalid discount value");
        }
    }
    public double CalculateTotal()  // Calculate total price after discount
    {
        double total = Price * Quantity;
        double discountAmount = total * (Discount / 100);
        return total - discountAmount;
    }
    public void DisplayProductDetails(object obj)     // Method using 'is' operator for safe type checking
    {
        if (obj is Product)
        {
            Console.WriteLine("Product ID : " + ProductID);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price : ₹" + Price);
            Console.WriteLine("Quantity : " + Quantity);
            Console.WriteLine("Discount : " + Discount + "%");
            Console.WriteLine("Total Price: ₹" + CalculateTotal());
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid product object");
        }
    }
}
// Main class
class ShoppingCart
{
    static void Main(string[] args)
    {
        Product p1 = new Product(101, "Laptop", 60000, 1);
        Product p2 = new Product(102, "Headphones", 2000, 2);
        p1.DisplayProductDetails(p1);
        p2.DisplayProductDetails(p2);
        // Update discount for all products
        Product.UpdateDiscount(15);
        Console.WriteLine("After Updating Discount:\n");
        p1.DisplayProductDetails(p1);
        p2.DisplayProductDetails(p2);
    }
}

