// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");;
int num1= Convert.ToInt32(Console.ReadLine ( ));

 bool DayChecking(int a)
 {
    return (a==6 || a==7);
 }

bool result = DayChecking(num1);
Console.Write(result? "да" : "нет");
