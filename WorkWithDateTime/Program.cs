using System;
using System.Globalization;
//Вывести на экран текущее название дня недели, название месяца и свое имя. Каждое слово должно быть в отдельной строке.
//
namespace WorkWithDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dayValue = DateTime.Now;
            Console.WriteLine(dayValue.DayOfWeek);
            CultureInfo culInf = new CultureInfo("ru-RU");
            string monthNames = culInf.DateTimeFormat.GetMonthName(dayValue.Month);
            Console.WriteLine(monthNames);
            Console.WriteLine("Basil");
            Console.ReadLine();
        }
    }
}
