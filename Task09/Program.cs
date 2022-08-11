// Напишите программу, которая 
// 1.выводит случайное число из отрезка [10, 99] 
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 10? 99+1 (100 не входит в диапозон)
Console.WriteLine($"Случайное число из отрезка 10 -99 => {number}");

// int firstDigit = number/10;
// int secondDigit = number%10;

// if (firstDigit==secondDigit) Console.WriteLine($"Числа равны");
// else
// {
    // int max = firstDigit;
//  if (secondDigit>max) max = secondDigit;
// int max = firstDigit>secondDigit ? firstDigit : secondDigit;
// переменная макс = первое число больше второго? если да, 
// то принимаем значение первого числа ":" - иначе, значение второго числа
// Console.WriteLine($"Наибольшая цифра числа {number} => {max}");
// }

int MaxDig(int num)
{
    int firstDigit = number/10;
    int secondDigit = number%10;
    if (firstDigit==secondDigit) return -1;
    return firstDigit>secondDigit ? firstDigit : secondDigit;
}

int maxDig= MaxDig(number);
string result = maxDig != -1 ? maxDig.ToString() : "Числа одинаковые";
Console.WriteLine($"Наибольшая цифра числа {number} => {maxDig}");
