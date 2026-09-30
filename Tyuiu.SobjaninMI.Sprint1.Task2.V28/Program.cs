using Tyuiu.SobjaninMI.Sprint1.Task2.V28.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Собянин М. И. | СМАРТб-26-1";
//Длинна строки 75 символов
Console.WriteLine("***************************************************************");
Console.WriteLine("* Спринт #1                                                   *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                            *");
Console.WriteLine("* Задание #2                                                  *");
Console.WriteLine("* Вариант #28                                                 *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                    *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя      *");
Console.WriteLine("* исходные данные, выполняет указанные расчёты и печатает     *");
Console.WriteLine("* результат на экране.                                        *");
Console.WriteLine("*                                                             *");
Console.WriteLine("* Известна температура в градусах Цельсия. Перевести          *");
Console.WriteLine("* температуру в градусы Кельвина.                             *");
Console.WriteLine("*                                                             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                            *");
Console.WriteLine("***************************************************************");

int x;

Console.WriteLine("Введите значение температуры в градусах Цельсия:");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                  *");
Console.WriteLine("***************************************************************");

Console.WriteLine("Температура в градусах Кельвина = " + ds.ConvertCelsiusToKelvin(x));

Console.ReadKey();