namespace hw1;

public class Case4
{
    public static void Execute()
    {
        Console.Write("Введите положительное действительное число x: ");
        double x = double.Parse(Console.ReadLine());
        
        double fractionalPart = x - (int)x;

        Console.WriteLine($"Дробная часть числа x: {fractionalPart}");
    }
}