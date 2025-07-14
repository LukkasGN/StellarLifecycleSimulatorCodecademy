using System;

public class Star
{
    // Fields
    public string name;
    public string type;
    public int age;
    public double brightness;

    // Constructor: name + type
    public Star(string name, string type)
    {
        this.name = name;
        this.type = type;
        this.age = 0;
        this.brightness = 1.0;
    }

    // Constructor: only name, type = "Unknown"
    public Star(string name)
    {
        this.name = name;
        this.type = "Unknown";
        this.age = 0;
        this.brightness = 1.0;

        Console.WriteLine("Star type set to default: Unknown.");
    }

    // Method: Shine
    public void Shine()
    {
        Console.WriteLine($"Star {name} is shining with brightness {brightness}.");
    }

    // Method: GrowOlder
    public void GrowOlder()
    {
        age += 1;
        brightness *= 0.9; // decrease by 10%
    }

    // Method: Supernova
    public void Supernova()
    {
        brightness = 0;
        Console.WriteLine($"Star {name} has exploded in a supernova.");
    }
}
