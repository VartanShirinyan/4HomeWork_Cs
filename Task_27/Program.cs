// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите положительное число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {suma(a)}");

int suma(int a)
{
    int sum = 0;
    int i = 0;

    while (a > 0)
    {
        i = a % 10;
        sum = sum + i;
        a /= 10;
    }
    return +sum;
}