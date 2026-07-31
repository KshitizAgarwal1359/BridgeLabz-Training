using System;
class BirdSanctuary
{
    public static void Main(String[] args)
    {
        Bird[] birds = new Bird[]
        {
            new Eagle("Rocky"),
            new Sparrow("Pinki"),
            new Duck("Kalo"),
            new Penguin("Chameli"),
            new Seagull("Rihana")
        };

        foreach(Bird bird in birds)
        {
            bird.DisplayInfo();
            if(bird is IFlyable flyable)
            {
                flyable.Fly();
            }
            if(bird is ISwimmable swimmable)
            {
                swimmable.Swim();
            }
            Console.WriteLine("\n");
        }

    }
}
