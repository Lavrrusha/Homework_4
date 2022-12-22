/*
 * Задача 27
 * Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 */

int[] numbers = new int[8];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите число в элемент массива с индексом {i}: ");
    while (true)
    {
        try
        {
            numbers[i] = int.Parse(Console.ReadLine());
            break;
        }
        catch
        {
            Console.WriteLine($"Строка не является числом!");
            Console.Write($"Введите число в элемент массива с индексом {i}: ");
        }
    }
}

Console.WriteLine($"Введен массив: [{string.Join(',', numbers)}]");