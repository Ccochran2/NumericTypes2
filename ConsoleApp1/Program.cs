using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What's the width of the rectangle?");
        string rectangleWidthInput = Console.ReadLine();
        

        Console.WriteLine("What's the length of the rectangle?");
        string rectangleHeightInput = Console.ReadLine();

        if (double.TryParse(rectangleHeightInput, out double rectangleHeight) && double.TryParse(rectangleWidthInput, out double rectangleWidth))
        {
            double area = rectangleWidth * rectangleHeight;
            Console.WriteLine($"The area of this rectangle is { area }.");
        } else
        {
            Console.WriteLine("One of your inputs was not a number. Please only input real numbers. Numbers with decimal points is fine, too.");
        }
    }
}