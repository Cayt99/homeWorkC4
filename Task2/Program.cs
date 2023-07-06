// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int tempNumber = Math.Abs(number);

for (int i = tempNumber; i > 0; i /= 10)
{
    sum += tempNumber % 10;
    tempNumber /= 10;
}

Console.WriteLine("Сумма цифр числа " + number + " равна " + sum);
