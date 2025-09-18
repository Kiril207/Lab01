using System;
class Program1
{
    static void Main()
    {
        Console.WriteLine($"sbyte: Min= {sbyte.MinValue}, Max= {sbyte.MaxValue}");
        Console.WriteLine($"byte: Min = {byte.MinValue}, Max= {byte.MaxValue}");
        Console.WriteLine($"short: Min={short.MinValue}, Max={short.MaxValue}");
        Console.WriteLine($"ushort: Min={ushort.MinValue}, Max={ushort.MaxValue}");
        Console.WriteLine($"int: Min={int.MinValue}, Max={int.MaxValue}");
        Console.WriteLine($"uint: Min={uint.MinValue}, Max={uint.MaxValue}");
        Console.WriteLine($"long: Min={long.MinValue}, Max={long.MaxValue}");
        Console.WriteLine($"ulong: Min={ulong.MinValue}, Max={ulong.MaxValue}");
        Console.WriteLine();
        Console.WriteLine("Числа с плавающей точкой");
        Console.WriteLine($"float: Min={float.MinValue}, Max={float.MaxValue}");
        Console.WriteLine($"double: Min={double.MinValue}, Max={double.MaxValue}");
        Console.WriteLine($"decimal: Min={decimal.MinValue}, Max={decimal.MaxValue}");
        Console.WriteLine();
        Console.WriteLine("Символьныый тип");
        Console.WriteLine($"char: Min={char.MinValue}, Max={char.MaxValue}");
        Console.WriteLine();
        Console.WriteLine("Логический тип");
        Console.WriteLine($"bool: Values={false},{true}");
    }
}