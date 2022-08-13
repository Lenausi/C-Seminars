// 1. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


//  Решение №1:
// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное трехзначное число => {number}");
// int firstDigit = number/100;
// int ThirdDigit = number%10 ;

// int result = firstDigit*10+ThirdDigit;
// System.Console.WriteLine($"После удаления второй цифры получается число -> {result}");


// Решение №2
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {number}");


int NewDig(int num)
{
int firstDigit = num/100;
int ThirdDigit = num%10 ;
int result  = firstDigit*10+ThirdDigit;
return result;
}

int result = NewDig (number);
Console.WriteLine($"Случайное трехзначное число => {result}");