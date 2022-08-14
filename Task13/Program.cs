// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");;
int num1= Convert.ToInt32(Console.ReadLine ( ));

int FindThirdDig (int a)
{
    int thirdDig=1;
   if (a>99 && a<999)  thirdDig = a%10;
   else if (a>999 && a<9999)  thirdDig = a/10%10;
   else if (a>9999 && a<99999)  thirdDig =  a/100%10;
   else if (a>99999 && a<999999)  thirdDig =  a/1000%10;
   else if (a>999999 && a<9999999) thirdDig =  a/10000%10;
   else if (a>9999999 && a<99999999) thirdDig =  a/10000%10;
   else if (a>99999999 && a<2147483646) thirdDig =  a/100000%10;
   else  thirdDig = -1;
   return thirdDig;
}

int result = FindThirdDig(num1);
string solution = result != -1 ? result.ToString($"Третья цифра числа {num1} равна {result}") : "Третьей цифры нет";
System.Console.WriteLine(solution);




 // do
    // {int thirdDig = a%10;
    // return thirdDig;}
    // while (a>99 && a<999);

    //  do
    // {int thirdDig = a/10%10;
    // return thirdDig;}
    // while (a>999 && a<9999);
    
    // do
    // {int thirdDig = a/100%10;
    // return thirdDig;}
    // while (a>9999 && a<99999);
    
    // do
    // {int thirdDig = a/1000%10;
    // return thirdDig;}
    // while (a>999999 && a<9999999);

    // do
    // {int thirdDig = a/100000%10;
    // return thirdDig;}
    // while (a>9999999 && a<9999999);