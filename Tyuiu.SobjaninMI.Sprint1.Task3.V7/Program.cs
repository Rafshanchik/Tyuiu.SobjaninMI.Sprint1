using Tyuiu.SobjaninMI.Sprint1.Task3.V7.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Собянин М. И. | СМАРТб-26-1";
//Длинна строки 75 символов
Console.WriteLine("***************************************************************");
Console.WriteLine("* Спринт #1                                                   *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                            *");
Console.WriteLine("* Задание #3                                                  *");
Console.WriteLine("* Вариант #7                                                  *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                    *");
Console.WriteLine("* Написать программу пересчета расстояния из верст            *");
Console.WriteLine("* в километры (1 верста — это 1066,8 м).                      *");
Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                  *");
Console.WriteLine("*                                                             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                            *");
Console.WriteLine("***************************************************************");

double versts;

Console.WriteLine("Введите расстояние в верстах ->");
versts = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                  *");
Console.WriteLine("***************************************************************");

double km = ds.VerstsToKilometers(versts);
Console.WriteLine($"{versts} верст - это {km} км.");

Console.ReadKey();