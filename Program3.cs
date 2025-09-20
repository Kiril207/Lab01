using System;

// Class representing a point in 2D space
class Point
{
    // Private fields to store coordinates
    private int x, y;
    
    // Public read-only property for X coordinate
    public int X
    {
        get { return x; }
    }
    
    // Public read-only property for Y coordinate
    public int Y
    {
        get { return y; }
    }
    
    // Constructor to initialize point with coordinates
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y; 
    }
    
    // Method to calculate Euclidean distance between two points
    public double Distance(Point other)
    {
        // Calculate distance using Pythagorean theorem
        double distance = Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        
        // Validation: distance cannot be zero
        if (distance == 0)
        {
            throw new ArgumentException("Distance cannot be zero");
        }
        return distance;
    }
   
}

// Class representing a geometric figure composed of points
class Figure
{
    // Array to store points that define the figure
    private Point[] points;
    
    // Name of the figure
    private string FigureName = "";
    
    // Constructor to initialize figure with points and name
    public Figure(Point[] points, string FigureName)
    {
        // Validation: figure must have 3-5 points (polygon constraints)
        if (points.Length < 3 || points.Length > 5)
        {
            throw new ArgumentException($"Figure {FigureName} is invalid. Must have 3 to 5 points");
        }
        this.FigureName = FigureName;
        this.points = points;
    }
    
    // Method to calculate length between two points
    public double LenghtSide(Point A, Point B)
    {
        return A.Distance(B); // Delegate to Point's Distance method
    }
    
    // Method to calculate total perimeter of the figure
    public double PerimeterCalculator()
    {
        double perimeter = 0;
        
        // Iterate through all points to sum side lengths
        for (int i = 0; i < points.Length; i++)
        {
            Point current = points[i]; 
            Point next = points[(i + 1) % points.Length]; // Wrap around to first point
            perimeter += LenghtSide(current, next); // Add each side's length
        }
        return perimeter;
    }
    
    // Method to get formatted information about the figure
    public string GetFigureInfo()
    {
        return $"{FigureName} with perimeter: {PerimeterCalculator()}";
    }
}

class Program
{
    // Main entry point of the application
    static void Main()
    {
        Console.WriteLine("Polygon Operations Program");
        Console.WriteLine("==========================");

        try
        {
            // Create point instances with coordinates
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 4);
            Point p3 = new Point(3, 0);
            Point p4 = new Point(3, 4);
            Point p5 = new Point(1, 2);
            Point p6 = new Point(5, 6);

            // Create different geometric figures
            Figure triangle = new Figure([p1, p2, p3], "Triangle"); // 3 points
            Figure rectangle = new Figure([p1, p2, p4, p3], "Rectangle"); // 4 points
            Figure pentagon = new Figure([p1, p2, p4, p3, p5], "Pentagon"); // 5 points

            // Display information about each figure
            Console.WriteLine(triangle.GetFigureInfo());
            Console.WriteLine(rectangle.GetFigureInfo());
            Console.WriteLine(pentagon.GetFigureInfo());

            // Demonstrate side length calculation method
            Console.WriteLine($"\nSide length between points ({p1.X},{p1.Y}) and ({p2.X},{p2.Y}): {triangle.LenghtSide(p1, p2)}");
        }
        catch (Exception ex)
        {
            // Handle any exceptions that occur during execution
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
