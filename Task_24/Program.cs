/* 24. Напишите прогу, которая принимает на вход число (А) и выдаёт сумму от 1 до А
7 -> 28
4 -> 10 */
int a;
Console.WriteLine($"Введите число А: ");
int.TryParse(Console.ReadLine()!, out a);
int sum = 0;
for (int i = 1; i <= a; i++)
{
    sum = sum + i;
}
Console.WriteLine($" Сумма от 1 до А: {sum}");