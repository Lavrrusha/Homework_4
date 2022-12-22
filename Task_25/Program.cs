/*
 * Задача 25
 * Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 */
 /* Метод для возведения в степень */
int Pow(int number, int degree){
    int tempNumber = number;
    while(degree > 1){
        number *= tempNumber;
        degree--;
    }
    return number;
}
Console.Write("Введите число A:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b}: {Pow(a,b)}");