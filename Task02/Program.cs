// Напишите программу, которая на выход принимает два числа и выдает, какое число большее,а какое меньшее
// а = 5, b=7
// а = -2, b = 10
// а = -9, b = -3
Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine ($"большее число: {number1}, меньшее число: {number2}");
} else
{
 Console.WriteLine ($"большее число: {number2}, меньшее число: {number1}");   
}