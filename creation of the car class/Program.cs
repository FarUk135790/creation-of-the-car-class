using System;

public class Car
{
    // Fields
    private string name;
    private string color;
    private double price;

    // Constant field
    private const string CompanyName = "XYZ Motors";

    // Constructors
    public Car()
    {
        // Default constructor
    }

    public Car(string name, string color, double price)
    {
        this.name = name;
        this.color = color;
        this.price = price;
    }

    // Methods
    public void Input()
    {
        Console.WriteLine("Enter car details:");
        Console.Write("Name: ");
        name = Console.ReadLine();

        Console.Write("Color: ");
        color = Console.ReadLine();

        Console.Write("Price: ");
        if (double.TryParse(Console.ReadLine(), out double enteredPrice))
        {
            price = enteredPrice;
        }
        else
        {
            Console.WriteLine("Invalid input for price. Defaulting to 0.");
            price = 0;
        }
    }

    public void Print()
    {
        Console.WriteLine($"Car Details:\nName: {name}\nColor: {color}\nPrice: {price:C}\nCompany: {CompanyName}");
    }

    public void ChangePrice(double x)
    {
        price -= price * (x / 100);
    }

    public void PaintCar(string newColor)
    {
        if (color.ToLower() == "white")
        {
            color = newColor;
            Console.WriteLine($"Car painted to {newColor}.");
        }
        else
        {
            Console.WriteLine("Car cannot be painted because it is not white.");
        }
    }

    public string PrintInfo()
    {
        return $"Name: {name}, Color: {color}, Price: {price:C}, Company: {CompanyName}";
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        car1.Input();

        Car car2 = new Car("Model S", "Blue", 50000);

        Car car3 = new Car();
        car3.Input();

        // Decrease price by 10%
        car1.ChangePrice(10);
        car2.ChangePrice(10);
        car3.ChangePrice(10);

        // Print car details
        Console.WriteLine("\nCar Details After Price Reduction:");
        car1.Print();
        car2.Print();
        car3.Print();

        // Paint car with color other than white
        Console.Write("\nEnter the new color to paint the white car: ");
        string newColor = Console.ReadLine();
        car1.PaintCar(newColor);

        // Print car details using PrintInfo method
        Console.WriteLine("\nCar Details Using PrintInfo Method:");
        Console.WriteLine(car1.PrintInfo());
        Console.WriteLine(car2.PrintInfo());
        Console.WriteLine(car3.PrintInfo());
    }
}