namespace hw1;

public class Case5
{
    public static void Execute()
    {
        Console.Write("Введите количество жителей в государстве: ");
        int population = int.Parse(Console.ReadLine());

        Console.Write("Введите площадь территории государства (в квадратных километрах): ");
        double area = double.Parse(Console.ReadLine());

        // Вычисляем плотность населения
        double density = population / area;

        Console.WriteLine($"Плотность населения: {density} человек/кв. км");
    }
}