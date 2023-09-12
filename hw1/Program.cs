namespace hw1;

abstract class Program
{
    static string? Menu()
    {
        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("1) Ввести число и вывести на экран");
        Console.WriteLine("2) Вывести числа 7, 15 и 100 с двумя пробелами между ними");
        Console.WriteLine("3) Найти сумму и произведение трёх целых чисел");
        Console.WriteLine("4) Вывести дробную часть положительного действительного числа");
        Console.WriteLine("5) Рассчитать плотность населения");
        Console.WriteLine("6) Вычислить значения функций");
        Console.WriteLine("7) Расчитать секунды");
        Console.WriteLine("8) Отзеркалить трехзначное число");
        Console.WriteLine("9) Конвертация градусов");
        Console.WriteLine("10) Найти диаметр, длину окружности и площадь круга");
        Console.WriteLine("0) Выйти из программы");
        Console.Write("Введите номер действия: ");

        return Console.ReadLine();
    }
    
    static void Main()
    {
        while (true)
        {
            var choice = Menu();

            switch (choice)
            {
                case "1":
                    Case1.Execute();
                    break;

                case "2":
                    Case2.Execute();
                    break;

                case "3":
                    Case3.Execute();
                    break;

                case "4":
                    Case4.Execute();
                    break;

                case "5":
                    Case5.Execute();
                    break;

                case "6":
                    Case6.Execute();
                    break;
                
                case "7":
                    Case7.Execute();
                    break;
                
                case "8":
                    Case8.Execute();
                    break;
                
                case "9":
                    Case9.Execute();
                    break;
                
                case "10":
                    Case10.Execute();
                    break;

                case "0":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}