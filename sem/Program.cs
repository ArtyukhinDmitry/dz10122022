

// int Count(int A)
// {
//     int rez = 0;
//     while (A != 0)
//     {
//         A = A / 10;
//         rez++;
//     }
//     return rez;
// }
// Console.Write("Введите число А: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Count(N));


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 5 -> 120

// int GetSum(int A)
// {
//     int prod = 1;
//     for (int i = 1; i <= A; i++)
//     {
//         prod *= i;
//     }
//     return prod;
// }
// Console.Write("Введите число А: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(GetSum(N));


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int GetPush (int number);
// {
//     int sum = 1;
//     for (int = 1; int <= number; int++)
//     {
//         sum = sum * i;
//     }
//     return sum;
// }
// Console.Write("Введите любое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetPush(number));


// Задача 

// int[] GetArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
//     return array;
// }
// var str = string.Join(" ", GetArray());
// Console.WriteLine(str);