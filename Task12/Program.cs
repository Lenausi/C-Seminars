//  Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");;
int num1= Convert.ToInt32(Console.ReadLine ( ));
Console.Write("Введите второе число: ");;
int num2= Convert.ToInt32(Console.ReadLine ( ));

int CheckingQuad (int a, int b)
{
    if (a% b==0) Console.Write($"Второе число кратно первому");
    return a%b;
}

int result = CheckingQuad(num1, num2);
Console.Write($"Второе число не кратно первому, остаток от деления равен: {result}");