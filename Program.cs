using System;

// Class representing a geometric rectangle
class Rectangle
{
    // Private fields to store the dimensions of the rectangle
    private double sideA;
    private double sideB;
    
    // Constructor that initializes the rectangle with specified sides
    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA; // Assign parameter to class field
        this.sideB = sideB; // Assign parameter to class field
    }
    
    // Private method to calculate the area (encapsulation)
    private double CalculateArea()
    {
        return sideA * sideB; // Area formula: length × width
    }
    
    // Private method to calculate the perimeter (encapsulation)
    // Note: Method name has a typo - should be CalculatePerimeter
    private double CalculatePeremeter()
    {
        return 2 * (sideA + sideB); // Perimeter formula: 2 × (length + width)
    }
    
    // Public property to expose the calculated area (read-only)
    public double Area
    {
        get { return CalculateArea(); } // Returns calculated area when accessed
    }
    
    // Public property to expose the calculated perimeter (read-only)
    public double Perimeter
    {
        get { return CalculatePeremeter(); } // Returns calculated perimeter when accessed
    }
}

class Program
{
    // Main entry point of the application
    static void Main()
    {
        Console.WriteLine("Rectangle Area and Perimeter Calculator");
        Console.WriteLine();
        
        try // Exception handling for unexpected errors
        {
            // Get side A from user with validation
            Console.Write("Enter length of side A: ");
            double sideA = GetPositiveNumber(); // Calls validation method

            // Get side B from user with validation
            Console.Write("Enter length of side B: ");
            double sideB = GetPositiveNumber(); // Calls validation method

            // Create Rectangle object with validated dimensions
            Rectangle rectangle = new Rectangle(sideA, sideB);
            
            // Display calculation results
            Console.WriteLine("\nResults:");
            Console.WriteLine($"Rectangle area: {rectangle.Area}"); // Access Area property
            Console.WriteLine($"Rectangle perimeter: {rectangle.Perimeter}"); // Access Perimeter property
        }
        catch(Exception e) // Catch any unexpected exceptions
        {
            Console.WriteLine($"Error: {e.Message}"); // Display error message to user
        }
    }
    
    // Helper method to validate and get positive numeric input
    private static double GetPositiveNumber()
    {
        // Infinite loop until valid input is received
        while (true)
        {
            // Try to parse input and check if it's positive
            if (double.TryParse(Console.ReadLine(), out double number) && number > 0)
            {
                return number; // Return valid positive number
            }
            // Prompt user again if input is invalid
            Console.Write("Error! Please enter a positive number: ");
        }
    }
}
