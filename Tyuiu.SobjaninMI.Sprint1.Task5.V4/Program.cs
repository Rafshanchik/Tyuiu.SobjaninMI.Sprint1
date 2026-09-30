using Tyuiu.SobjaninMI.Sprint1.Task5.V4.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Собянин М. И. | СМАРТб-26-1";
//Длинна строки 75 символов
Console.WriteLine("***************************************************************");
Console.WriteLine("* Спринт #1                                                   *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                            *");
Console.WriteLine("* Задание #5                                                  *");
Console.WriteLine("* Вариант #4                                                  *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                    *");
Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов    *");
Console.WriteLine("* (h) прошло к этому моменту (например, h=3, если k=13257).   *");
Console.WriteLine("*                                                             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                            *");
Console.WriteLine("***************************************************************");

int k;

Console.WriteLine("Введите число k (секунда суток):");
k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                  *");
Console.WriteLine("***************************************************************");

Console.WriteLine("Полных часов прошло: " + ds.SecondsToHours(k));

Console.ReadKey();