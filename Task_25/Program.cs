// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число (A) затем нажмите enter и введите число (B): ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"(A) в степени (B) равно: {step(a, b)}");

int step(int a, int b)
{
    int degree = a;
    for (int i = 1; i < b; i++)
    {
        degree = degree * a;
    }
    return +degree;
}