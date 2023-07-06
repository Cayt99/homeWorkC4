// Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(10, 1001);
// }

// Console.WriteLine("Сгенерированный массив:");
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// ___________________________________________________________________________________________________________________________________________________________________________
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива[" + i + "]: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int value))
    {
        array[i] = value;
    }
    else
    {
        Console.WriteLine("Ошибка! Введено не целочисленное значение.");
        i--; // Уменьшение i для повторного запроса текущего индекса
    }
}

Console.WriteLine("Введенный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");
