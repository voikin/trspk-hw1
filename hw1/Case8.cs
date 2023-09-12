namespace hw1;

public class Case8
{
    public static void Execute()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        // Получаем цифры числа
        int digit1 = number % 10;
        int digit2 = (number / 10) % 10;
        int digit3 = (number / 100) % 10;

        // Формируем новое число, читая цифры справа налево
        int reversedNumber = digit1 * 100 + digit2 * 10 + digit3;

        Console.WriteLine($"Число, полученное при прочтении цифр справа налево: {reversedNumber}");
    }
}