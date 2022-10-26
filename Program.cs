
// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

// int number = new Random().Next(10, 100);
// int num1 = number / 10;
// int num2 = number % 10;
// int max = num1;
// if (max < num2)
// {
//     max = num2;
// }
// Console.WriteLine($"Максимальная цифра числа {number} равна {max}");






// **1 задача** Напишите программу, которая выводит 
// случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random().Next(100, 1000);

// int num1 = number / 100;
// int num2 = number % 10;

// Console.WriteLine(number);
// Console.Write($"{num1} {num2}");






// **2 задача** Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно числу первому, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Введите число 1: ");
// int number1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число 2: ");
// int number2 = int.Parse(Console.ReadLine()!);
// int number = number1 % number2;
// if(number == 0)
// {
//     Console.WriteLine("Второе число кратно ");
// }
// else
// {
//     Console.WriteLine($"Второе число некратно первому: остаток {number} ");
// }





// **3 задача** Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да


// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// if ((number % 7 == 0) && (number%23 == 0))
// {
//     Console.WriteLine($"Число {number} кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine($"Число {number} некратно ");
// }






// **4 задача** Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.

// Console.WriteLine("Введите число1: ");
// int number1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число2: ");
// int number2 = int.Parse(Console.ReadLine()!);

// if (number1 / number2 == number1 || number1 / number2 == number2)
// {
//     Console.WriteLine("Является квадратом другого");
// }
// else
// {
//     Console.WriteLine("Нет, не является");
// }

// Второй вариант решения задачи

Console.WriteLine("Введите два числа: ");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
if(number1>number2)
{
    if(number1==Math.Pow(number2,2))
    {
       Console.WriteLine($"{number1} Является квадратом другого числа{number2}"); 
    }
    else
    {
        Console.WriteLine($"{number1} Неявляется квадратом другого числа{number2}");
    }
}
else
{
    if(number1==Math.Pow(number1,2))
    {
       Console.WriteLine($"{number1} Является квадратом другого числа{number2}"); 
    }
    else
    {
        Console.WriteLine($"{number1} Неявляется квадратом другого числа{number2}");
    }
}