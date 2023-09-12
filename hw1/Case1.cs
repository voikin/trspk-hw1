namespace hw1;

public class Case1
{
    public static void Execute()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();
        Console.WriteLine(int.TryParse(input, out int number)
            ? $"Вы ввели число: {number}"
            : "Неверный ввод. Введите целое число.");
    }
}