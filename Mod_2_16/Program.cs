using System;

namespace Mod_2_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4-значное число: ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1000 && n <= 9999)
            {
                int first = n % 10;
                int sec = (n / 10) % 10;
                int thir = (n / 100) % 10;
                int fourth = (n / 1000) % 10;

                int sum = first + sec + thir + fourth;
                Console.WriteLine($"Сумма цифр числа {n} равна {sum}");

                int mult = first * sec * thir * fourth;
                Console.WriteLine($"Произведение цифр числа {n} равно {mult}");
            }
            else
            {
                Console.WriteLine("Введенное число не является четырехзначным.");
            }
        }
    }
}
