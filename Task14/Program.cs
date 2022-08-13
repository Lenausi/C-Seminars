// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");;
int num1= Convert.ToInt32(Console.ReadLine ( ));


bool CheckingQuad (int a)

{
return (a%7==0 && a%23==0);

}

bool result = CheckingQuad(num1);
Console.Write(result? "да" : "нет");

