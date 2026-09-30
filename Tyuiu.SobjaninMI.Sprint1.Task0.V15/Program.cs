using Tyuiu.SobjaninMI.Sprint1.Task0.V15.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Собянин М. И. | СМАРТб-26-1";
//Длинна строки 75 символов
Console.WriteLine("***************************************************************");
Console.WriteLine("* Спринт #1                                                   *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                            *");
Console.WriteLine("* Задание #0                                                  *");
Console.WriteLine("* Вариант #15                                                 *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                    *");
Console.WriteLine("* Написать программу, которая вычисляет выражение             *");
Console.WriteLine("* 20 - (2*2-8) и печатает результат на экране.                *");
Console.WriteLine("*                                                             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                            *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* 20 - (2*2-8)                                                *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                  *");
Console.WriteLine("***************************************************************");

Console.WriteLine(ds.Calculate());

Console.ReadKey();