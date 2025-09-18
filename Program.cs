using System;

class Rectangle
{
    private double sideA;
    private double sideB;
    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA; 
        this.sideB = sideB;
    }
    private double CalculateArea()
    {
        return sideA * sideB;
    }
    private double CalculatePeremeter()
    {
        return 2 * (sideA + sideB);
    }
    public double Area
    {
        get {  return CalculateArea(); }
    }
    public double Perimeter
    {
        get { return CalculatePeremeter(); }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для вычисления площади и приметра");
        Console.WriteLine();
        try
        {
            Console.Write("Введите длину стороны A: ");
            double sideA=GetPositiveNumber();

            Console.Write("Введите длину стороны B: ");
            double sideB=GetPositiveNumber();

            Rectangle rectangle= new Rectangle(sideA, sideB);
            Console.WriteLine("\nРезультаты");
            Console.WriteLine($"площадь прямоугольника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");

        }
        catch(Exception e) 
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
    private static double GetPositiveNumber()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double number) && number > 0)
            {
                return number;
            }
            Console.Write("Ошибка! Введите положительное число: ");
        }
    }
}