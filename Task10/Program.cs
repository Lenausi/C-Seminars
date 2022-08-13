// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int num1= Convert.ToInt32(Console.ReadLine ( ));


int NewDig(int a)
{
    if (a>=100 && a<1000) return a%100/10;
return -1;
}

int result = NewDig (num1);
string solution = result != -1 ? result.ToString($"Вторая цифра числа {num1} равна {result}") : "Введено некорректное число, пожалуйста, повторите ввод";
Console.WriteLine($"{solution}");
