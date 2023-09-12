namespace hw1;

public class Case10
{
    public static void Execute()
    {
        Console.Write("Введите радиус круга: ");
        double radius = double.Parse(Console.ReadLine());

        // Вычисляем диаметр
        double diameter = 2 * radius;

        // Вычисляем длину окружности
        double circumference = 2 * Math.PI * radius;

        // Вычисляем площадь круга
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine($"Диаметр круга: {diameter}");
        Console.WriteLine($"Длина окружности: {circumference}");
        Console.WriteLine($"Площадь круга: {area}");
    }
}