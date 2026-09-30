using Tyuiu.SobjaninMI.Sprint1.Task6.V17.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Собянин М. И. | СМАРТб-26-1";
//Длинна строки 75 символов
Console.WriteLine("***************************************************************");
Console.WriteLine("* Спринт #1                                                   *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                            *");
Console.WriteLine("* Задание #6                                                  *");
Console.WriteLine("* Вариант #17                                                 *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                    *");
Console.WriteLine("* Пользователь вводит текст.                                  *");
Console.WriteLine("* Проверить, что строка является перевертышем.                *");
Console.WriteLine("*                                                             *");
Console.WriteLine("***************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                            *");
Console.WriteLine("***************************************************************");

string value;

Console.WriteLine("Введите строку:");
value = Console.ReadLine();

Console.WriteLine("***************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                  *");
Console.WriteLine("***************************************************************");

if (ds.CheckPalindrome(value))
{
    Console.WriteLine("Строка является перевертышем");
}
else
{
    Console.WriteLine("Строка НЕ является перевертышем");
}

Console.ReadKey();