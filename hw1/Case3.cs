namespace hw1;

public class Case3
{
    public static void Execute()
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int num3 = int.Parse(Console.ReadLine());

        int sum = num1 + num2 + num3;
        int product = num1 * num2 * num3;

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product}");
    }
}