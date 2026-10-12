// int[] marks = {5, 4, 3, 5, 4};
// int[] numbers = new int[5];

// Console.WriteLine(marks[0]);
// Console.WriteLine(marks[4]);

// marks[2] = 4;


// for (int i = 0; i < marks.Length; i++){
//     Console.WriteLine($"marks[{i}] = {marks[i]}");
// }

// foreach (int mark in marks)
// {
//     Console.WriteLine(mark);
// }

// Задание 1.1

// string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт"};

// for (int i = 0; i < days.Length; i++)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }

// Задание 1.1. Решение

// string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};

// for (int i = days.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine($"{i+1}: {days[i]}");
// }

// Задание 1.2

// double[] temps = {30, 26, -10, 15, -5, -7, 2};

// foreach(double t in temps)
// {
//     Console.Write(t + " ");
// }

// int[] marks = {5, 4, 3, 5, 4};
// int sum = 0;

// foreach(int mark in marks)
// {
//     sum += mark;
// }

// double average = (double)sum / marks.Length;
// Console.WriteLine($"Сумма: {sum}, среднее: {average}");

// Задание 2

// int[] prices = {120, 45, 300, 80, 15, 210};
// int sum = 0;
// int count = 0;
// foreach(int price in prices)
// {
//     sum+=price;
//     if(price > 100)
//     {
//         count++;
//     }
// }

// double average = (double)sum / prices.Length;

// Console.WriteLine($"Общая сумма цен: {sum}");

// Console.WriteLine($"Средняя цена: {average}");

// Console.WriteLine($"Количество больше 100: {count}");

// int[] numbers = {7, -2, 15, 4, 9};
// int max = numbers[0];
// for(int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
// }

// Console.WriteLine($"Максимум: {max}");

// Задание 3

// int[] prices = {120, 45, 300, 80, 15, 210};
// int sum = 0;
// int count = 0;
// foreach(int price in prices)
// {
//     sum += price;
//     if(price > 100)
//     {
//         count++;
//     }
// }

// int min = prices[0];
// int max = 0;
// for (int i = 0; i < prices.Length; i++){
//     if (prices[i] < min)
//     {
//         min = prices[i];
//     }
//     if (prices[i] > prices[max])
//     {
//         max = i;
//     }
// }

// double average = (double)sum / prices.Length;

// Console.WriteLine($"Общая сумма цен: {sum}");

// Console.WriteLine($"Средняя цена: {average}");

// Console.WriteLine($"Количество больше 100: {count}");

// Console.WriteLine($"Минимальная цена: {min}");

// Console.WriteLine($"Индекс максимальной цены: {max}");

// int[] numbers = {1, 2, 3, 4, 5};
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = numbers[i] * 2;
// }

// foreach (int n in numbers)
// {
//     Console.Write(n + " ");
// }

// int[] balance = {100, -50, 20, -5, 0, 75};
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }

// foreach(int b in balance){
//     Console.Write(b + " ");
// }

// Самостоятельные задания

// Задание 5. Ввод с клавиатуры

// int[] array = new int[5];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write("Введите число: ");
//     int num = int.Parse(Console.ReadLine());
//     array[i] = num;
// }

// for (int i = array.Length - 1; i >= 0; i--)
// {
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
//     Console.WriteLine(array[i] + " ");
// }
// Console.Write($"Количество четных чисел: {count}");

// Задание 6. Поиск по имени.

// string[] names = {"Анна", "Игорь", "Мария", "Олег", "Ольга"};
// Console.Write("Введите имя: ");
// string searchName = Console.ReadLine();
// bool b = false;

// foreach (string i in names)
// {
//     Console.Write(i + " ");
// }

// Console.WriteLine();

// for(int item = 0; item < names.Length; item++)
// {
//     if(searchName == names[item])
//     {
//         Console.WriteLine($"Имя: {searchName} находится на {item} позиции.");
//         b = true;
//         break;
//     }
// }

// if (!b)
// {
//     Console.WriteLine($"Имя: {searchName} не найдено");   
// }

// Итоговая задача. «Журнал оценок»

// int[] grades = {2, 4, 5, 3, 2, 5, 3, 4};
// int sum = 0;
// int count = 0;

// foreach(int grade in grades)
// {
//     Console.Write(grade + " ");
// }

// Console.WriteLine();

// for (int item = 0; item < grades.Length; item++)
// {
//     sum += item;
//     count++;
// }

// double average = (double)sum / count;

// Console.WriteLine($"Средний балл: {average}");

// if (average >= 4.5)
// {
//     Console.WriteLine("Отличник");
// }
// else if (average >= 3.5)
// {
//     Console.WriteLine("Хорошист");
// }

// else
// {
//     Console.WriteLine("Есть над чем поработать");
// }

// Дополнительное задание ★★★

// int[] arr = {1, 2, 3, 4, 5, 6};

// for (int i = 0; i < arr.Length / 2; i++)
// {
//     int j = arr.Length - 1 - i;
//     int item = arr[i];
//     arr[i] = arr[j];
//     arr[j] = item;
// }

// foreach(int ar in arr)
// {
//     Console.Write(ar + " ");
// }