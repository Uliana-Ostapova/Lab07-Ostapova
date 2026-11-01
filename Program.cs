// Задание 1.1
// string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
// for (int i = days.Length - 1; i >= 0; i--) {
//     Console.WriteLine($"{i}: {days[i]}");
// };

// Задание 1.2
// double[] temps = { 17.2, 1.5, -5.3, 0.0, -2.8, 9.4, 14.7 };
// foreach (int n in temps)
// {
//     Console.Write($"{n} ");
// }

// Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int count = 0;
// foreach (int p in prices)
// {
//     sum += p;
//     if (p > 100)
//     {
//         count += 1;
//     }
// }
// double average = sum / prices.Length;
// Console.WriteLine($"Сумма: {sum}, средняя цена: {average}, дороже 100: {count} товара");

// Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int max = prices[0];
// int index = 0;
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] > max)
//     {
//         index += 1;
//     } else if (prices[i] < min)
//     {
//         min = prices[i];
//     }
// }
// Console.WriteLine($"Минимум: {min}, индекс самого дорогого: {index}");

// Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }
// foreach (int n in balance)
// {
//     Console.Write(n + " ");
// }

// Задание 5
// int[] numbers = new int[5];
// int count = 0;
// Console.WriteLine("Введите 5 целых чисел:");
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = numbers.Length - 1; i >= 0; i--)
// {
//     if (numbers[i] % 2 == 0)
//     {
//         count += 1;
//     }
//     Console.Write(numbers[i] + " ");
// }
// Console.WriteLine();
// Console.WriteLine($"Количество чётных чисел: {count}");

// Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// bool flag = false;
// Console.WriteLine("Введите имя:");
// string name = Console.ReadLine();
// for (int i = 1; i < names.Length; i++)
// {
//     if (names[i] == name)
//     {
//         Console.WriteLine($"Имя стоит на позиции: {i}");
//         flag = true;
//         break;
//     }
// }
// if (flag == false)
// {
//     Console.WriteLine("Не найдено");
// }

// Задание 7 (Журнал оценок)
// int[] grades = { 4, 5, 2, 3, 4, 5, 5, 3 };
// int sum = 0;
// int max = grades[0];
// int min = grades[0];
// int two = 0;
// int five = 0;
// for (int i = 0; i < grades.Length; i++)
// {
//     sum += grades[i];
//     if (grades[i] == 5)
//     {
//         five += 1;
//     } else if (grades[i] == 2)
//     {
//         two += 1;
//     }
//     if (grades[i] > max)
//     {
//         max = grades[i];
//     } else if (grades[i] < min)
//     {
//         min = grades[i];
//     }
//     Console.Write(grades[i] + " ");
// }
// double average = (double)sum / grades.Length;
// Console.WriteLine();
// Console.WriteLine($"Средняя оценка: {average}, наибольшая: {max}, наименьшая: {min}, двоек: {two}, пятёрок: {five}");
// if (average >= 4.5)
// {
//     Console.WriteLine("Отличник");
// } else if (average >= 3.5)
// {
//     Console.WriteLine("Хорошист");
// } else
// {
//     Console.WriteLine("Есть над чем поработать");
// }

// Задание 8 (Дополнительное)
int[] arr = { 1, 2, 3, 4, 5, 6 };
for (int i = 0; i < 3; i++)
{
    int num = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = num;
}
foreach (int n in arr)
{
    Console.Write(n + " ");
}
