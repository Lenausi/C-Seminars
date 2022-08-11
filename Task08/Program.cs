//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int i = 1;
int result = 0;
int Array = (number);
while(i<=number)
{{if (i%2==0)
    {result = i;}
};
i=i+1;}
Console.WriteLine($"Эти числа в диапозоне от 1 до {number} является четными: {result}");