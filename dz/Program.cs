// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Getdeg(int A, int B)
// {
// int number = A;
// int deg = B;
// for (int i = 1; i < B; i++)
// {
// number = number * A;
// }
// return number;
// }
// Console.WriteLine("введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("A в степени B равно: " + Getdeg(A, B));



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int GetSum(int A)
// {
//     int sum = 0;
//     while (A > 0)
//     {
//         int num = A % 10;
//         A = A / 10;
//         sum += num;
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(GetSum(N));



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] GetArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 99);
//     }
//     return array;
// }
// var str = string.Join(", ", GetArray());
// Console.WriteLine("[" + str + "]");
