using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 2; // задаем значение переменной a
        int b = 5; // задаем значение переменной b
        int result = 1; // задаем начальное значение для произведения

        for (int i = a; i <= b; i++)
        {
            result *= i; // умножаем текущее значение произведения на i
        }

        Console.WriteLine("Произведение всех целых чисел от {0} до {1} равно {2}", a, b, result);
        Console.ReadLine();
    }
}
