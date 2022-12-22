/*
 * Задача 27
 * Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 */
  /* Метод находит сумму цифр числа */
int SumDigit(int number)
{
    number = Math.Abs(number);
    int sum = 0;
    while (number > 0)
    {

        sum += number % 10;
        number /= 10;

    }
    return sum;
}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sumDigit = SumDigit(number);
Console.WriteLine($"Сумма цифр в числе {number}: {sumDigit}");