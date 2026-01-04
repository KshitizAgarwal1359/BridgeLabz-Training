using System;
class PersonRestaurant{ // Superclass
    public string Name;
    public int Id;
    public PersonRestaurant(string name,int id){
    Name = name;
    Id = id;
    }
    public void DisplayPersonDetails(){
    Console.WriteLine("Name: " + Name);
    Console.WriteLine("ID: " + Id);
    }
}
interface Worker{ // Interface — Worker
    void PerformDuties();
}
class Chef : PersonRestaurant, Worker{ // Subclass 1 — Chef
    public string Specialty;
    public Chef(string name, int id, string specialty): base(name, id){
    Specialty = specialty;
    }
    public void PerformDuties(){
    Console.WriteLine("\nRole: Chef");
    DisplayPersonDetails();
    Console.WriteLine("Specialty: " + Specialty);
    Console.WriteLine("Duties: Prepares meals and manages kitchen");
    }
}
class Waiter : PersonRestaurant, Worke{ // Subclass 2 — Waiter
    public string Shift;
    public Waiter(string name, int id, string shift): base(name, id){
    Shift = shift;
    }
    public void PerformDuties(){
    Console.WriteLine("\nRole: Waiter");
    DisplayPersonDetails();
    Console.WriteLine("Shift: " + Shift);
    Console.WriteLine("Duties: Serves customers and takes orders.");
    }
}
class RestaurantSystem{ // Main Class
    static void Main(string[] args){
        Chef chef1 = new Chef("Kshitiz", 361, "Indian Cuisine");
        Waiter waiter1 = new Waiter("Shashi", 565, "Evening Shift");
        chef1.PerformDuties();
        waiter1.PerformDuties();
    }
}