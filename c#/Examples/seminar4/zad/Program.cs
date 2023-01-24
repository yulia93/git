// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120



// System.Console.WriteLine("Введите число:");

// int num = int.Parse(Console.ReadLine());
// int i = 0;

// while (num > 0)
// {
//     i++;
//     num/=10;
// }

// Console.WriteLine("Количество цифр введенного числа: {0}", i);


// System.Console.WriteLine("Введите число:");

// int n = Convert.ToInt32(Console.ReadLine());
// int a = 1;

// for (int i = 1; i <= n; i++)
// {
//    a = a * i; 
// }

// System.Console.WriteLine(a);


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int [] a = new int[8];
// Random rnd = new Random();

// for (int i = 0; i < 8; i++)
// {
//     a[i] = rnd.Next(0,2);
//     System.Console.WriteLine(a[i]);
// }

int NextInt(int q = 123)
{
    return 5;
}
System.Console.WriteLine(NextInt());