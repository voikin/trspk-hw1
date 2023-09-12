namespace hw1;

public class Case6
{
    public static void Execute()
    {
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());

        // Вычисляем значение функции y=7x^2+3x+6
        double y = 7 * x * x + 3 * x + 6;

        Console.WriteLine($"Значение функции y=7x^2+3x+6 при x={x} равно {y}");

        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());

        // Вычисляем значение функции x=12a^2+7a+12
        double z = 12 * a * a + 7 * a + 12;

        Console.WriteLine($"Значение функции x=12a^2+7a+12 при a={a} равно {z}");
    }
}