using Tyuiu.SobjaninMI.Sprint1.Task4.V2.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Собянин М. И. | СМАРТб-26-1";
//Длинна строки 75 символов
Console.WriteLine("***************************************************************");
Console.WriteLine("* Спринт #1                                                   *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                            *");
Console.WriteLine("* Задание #4                                                  *");
Console.WriteLine("* Вариант #2                                                  *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                    *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя      *");
Console.WriteLine("* исходные данные, вычисляет результат по формуле             *");
Console.WriteLine("* 1 / sqrt(x + 2y) и печатает его на экране.                  *");
Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                  *");
Console.WriteLine("*                                                             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                            *");
Console.WriteLine("***************************************************************");

double x, y;

Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                  *");
Console.WriteLine("***************************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadKey();