// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите через проблел без запятых любые целые числа: ");
string? str = Console.ReadLine();

var arrStr = str.Split(" ");

int[] arr = Array.ConvertAll(arrStr, int.Parse);


int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += 1;
    }
    Console.WriteLine($"Количество элементов > 0: {sum}");