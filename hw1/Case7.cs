namespace hw1;

public class Case7
{
    public static void Execute()
    {
        Console.Write("Введите количество секунд: ");
        int seconds = int.Parse(Console.ReadLine());

        // Вычисляем сколько полных часов прошло
        int hours = seconds / 3600;

        // Остаток секунд после вычитания часов
        seconds %= 3600;

        // Вычисляем сколько полных минут прошло
        int minutes = seconds / 60;

        // Остаток секунд после вычитания минут
        seconds %= 60;

        Console.WriteLine($"Полных часов: {hours}");
        Console.WriteLine($"Полных минут: {minutes}");
        Console.WriteLine($"Полных секунд: {seconds}");
    }
}