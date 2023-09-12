namespace hw1;

public class Case9
{
    public static void Execute()
    {
        Console.Write("Введите температуру в градусах Цельсия: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit} °F");
        
        Console.Write("Введите температуру в градусах Фаренгейта: ");
        fahrenheit = double.Parse(Console.ReadLine());
        celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"Температура в градусах Цельсия: {celsius} °C");
    }
}