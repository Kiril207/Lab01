using System;

class Point
{
    private int x, y;
    public int X
    {
        get { return x; }
    }
    public int Y
    {
        get { return y; }
    }
    public Point(int x,int y)
    {
        this.x = x;
        this.y=y; 
    }
    public double Distance(Point other)
    {
        double distance = Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        if (distance == 0)
        {
            throw new ArgumentException("расстояние не может быть равно нулю");
        }
        return distance;
    }
   
}
class Figure
{
    private Point[] points;
    private string FigureName="";
    public Figure(Point[] points,string FigureName)
    {
        if (points.Length < 3 || points.Length > 5)
        {
            throw new ArgumentException($"Фигура {FigureName} не подходит, она должна иметь от 3 до 5 точек");
        }
        this.FigureName= FigureName;
        this.points= points;
    }
    public double LenghtSide(Point A,Point B)
    {
        return A.Distance(B);
    }
    public double PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            Point current= points[i]; 
            Point next = points[(i+1)%points.Length];
            perimeter += LenghtSide(current, next);
        }
        return perimeter;
    }
    public string GetFigureInfo()
    {
        return $"{FigureName} с периметром: {PerimeterCalculator()}";
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для работы с многоугольниками");
        Console.WriteLine("=======================================");

        try
        {
            // Создаем точки
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 4);
            Point p3 = new Point(3, 0);
            Point p4 = new Point(3, 4);
            Point p5 = new Point(1, 2);
            Point p6 = new Point(5, 6);

            // Создаем фигуры
            Figure triangle = new Figure([p1, p2, p3],"треугольник");
            Figure rectangle = new Figure([ p1, p2, p4, p3],"прямоугольник");
            Figure pentagon = new Figure([p1, p2, p4, p3, p5],"пентагон");

            // Выводим информацию
            Console.WriteLine(triangle.GetFigureInfo());
            Console.WriteLine(rectangle.GetFigureInfo());
            Console.WriteLine(pentagon.GetFigureInfo());

            // Демонстрация работы методов
            Console.WriteLine($"\nДлина стороны между {p1} и {p2}: {triangle.LenghtSide(p1,p2)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}