//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите число: ");;
int number1= Convert.ToInt32(Console.ReadLine ( ));
int result = number1%2;
if (result == 0)
{
    Console.WriteLine($"Введенное число {number1} является четным");
}
else
{
    Console.WriteLine($"Введенное число {number1} НЕ является четным");
}