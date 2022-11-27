// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("сумма всех цифр в числе равна: " + GetSumNam(num));

int GetSumNam(int i)
{
    int sum = 0;

    while (i > 0)
    {
        sum += i % 10;
        i = i / 10;
    }
    return sum;
}
