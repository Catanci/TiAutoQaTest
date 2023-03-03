using System;

class Program
{
    static void Main(string[] args)
    {
        double ax, ay, bx, by, cx, cy;

        Console.Write("Enter coordinate x of dot A:\n");
        if (!double.TryParse(Console.ReadLine(), out ax))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        Console.Write("Enter coordinate y of dot A:\n");
        if (!double.TryParse(Console.ReadLine(), out ay))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        Console.Write("Enter coordinate x of dot B:\n");
        if (!double.TryParse(Console.ReadLine(), out bx))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        Console.Write("Enter coordinate y of dot B:\n");
        if (!double.TryParse(Console.ReadLine(), out by))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        Console.Write("Enter coordinate x of dot C:\n");
        if (!double.TryParse(Console.ReadLine(), out cx))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        Console.Write("Enter coordinate y of dot C:\n");
        if (!double.TryParse(Console.ReadLine(), out cy))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        double side1 = (Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2)));
        double side2 = (Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2)));
        double side3 = (Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2)));

        //Output of the triangle sides
        Console.WriteLine($"Length of AB is: {side1}");
        Console.WriteLine($"Length of BC is: {side2}");
        Console.WriteLine($"Length of AC is: {side3}\n");

        //Checks if it is the Isosceles triangle
        if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("This is an 'Isosceles' triangle.");
        }
        else
        {
            Console.WriteLine("This is not an 'Isosceles' triangle.");
        }

        //Checks if the triangle is equilateral
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("This is an 'Equilateral' triangle.");
        }
        else
        {
            Console.WriteLine("This is NOT an 'Equilateral' triangle.");
        }

        //Checks if the triangle is right
        double delta = 0.000001;
        double a2 = side1 * side1;
        double b2 = side2 * side2;
        double c2 = side3 * side3;

        if (Math.Abs(b2 + c2 - a2) <= delta ||
            Math.Abs(a2 + c2 - b2) <= delta ||
            Math.Abs(a2 + b2 - c2) <= delta)
        {

            Console.WriteLine("This is a right triangle.\n");
        }
        else
        {
            Console.WriteLine("This is not a right triangle.\n");
        }

        //Calculates the perimeter
        double perimeter = side1 + side2 + side3;
        Console.WriteLine($"Perimeter: {perimeter}\n");

        //Output of the even numbers from 0 to the value of triangle perimeter
        Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
        for (int i = 0; i < perimeter; i++)
        {
            if (i % 2 == 0) Console.WriteLine(i);
        }
    }
}


