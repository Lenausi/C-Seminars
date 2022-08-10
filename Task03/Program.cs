//  Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.Write("Введите целое число соответствующее названию дня недели (от 1 до 7): ");;
int number = Convert.ToInt32(Console.ReadLine ( ));
string day = "";
if (number>=1 && number<=7)
{switch (number)
{case 1:
day = "Понедельник";
break;
    
    default:
    day = ("Вы ввели некорректное число");
    break;
}
    Console.WriteLine ("День недели:" + day);
}
