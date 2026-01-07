using System;
using System.Collections.Generic;
// Defines discount-related behavior
interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}
// Base class for all food items
abstract class FoodItem
{
    // Encapsulated fields
    private string itemName;
    private double price;
    private int quantity;

    // Properties with validation
    public string ItemName
    {
        get { return itemName; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Item name cannot be empty");
            itemName = value;
        }
    }

    public double Price
    {
        get { return price; }
        protected set
        {
            if (value < 0)
                throw new ArgumentException("Price cannot be negative");
            price = value;
        }
    }

    public int Quantity
    {
        get { return quantity; }
        protected set
        {
            if (value <= 0)
                throw new ArgumentException("Quantity must be greater than zero");
            quantity = value;
        }
    }

    // Constructor
    protected FoodItem(string itemName, double price, int quantity)
    {
        ItemName = itemName;
        Price = price;
        Quantity = quantity;
    }

    // Abstract method
    public abstract double CalculateTotalPrice();

    // Concrete method
    public virtual void GetItemDetails()
    {
        Console.WriteLine($"Item: {ItemName}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Quantity: {Quantity}");
    }
}
class VegItem : FoodItem, IDiscountable
{
    public VegItem(string name, double price, int quantity)
        : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return Price * Quantity; // No extra charge
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.10; // 10% discount
    }

    public string GetDiscountDetails()
    {
        return "Veg Item Discount: 10%";
    }
}
class NonVegItem : FoodItem, IDiscountable
{
    private const double NonVegCharge = 50;

    public NonVegItem(string name, double price, int quantity)
        : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (Price * Quantity) + NonVegCharge;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.05; // 5% discount
    }

    public string GetDiscountDetails()
    {
        return "Non-Veg Item Discount: 5%";
    }
}
class OnlineFoodDeliverySystem
{
    static void Main()
    {
        List<FoodItem> foodItems = new List<FoodItem>
        {
            new VegItem("Paneer Butter Masala", 250, 2),
            new NonVegItem("Chicken Biryani", 300, 1)
        };

        foreach (FoodItem item in foodItems)
        {
            item.GetItemDetails();

            double totalPrice = item.CalculateTotalPrice();
            double discount = 0;

            if (item is IDiscountable discountable)
            {
                discount = discountable.ApplyDiscount();
                Console.WriteLine(discountable.GetDiscountDetails());
            }

            double finalAmount = totalPrice - discount;

            Console.WriteLine($"Total Price: {totalPrice}");
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Final Amount: {finalAmount}");
            Console.WriteLine("----------------------------------");
        }
    }
}

