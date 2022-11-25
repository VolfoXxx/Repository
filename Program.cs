using System;
using System.Globalization;

namespace Дата_время
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParseExact
            string date = "05112022";
            DateTime dt = DateTime.ParseExact(date, "ddMMyyyy", CultureInfo.InvariantCulture);

            //Parse
            int a = int.Parse("230");
            double b = double.Parse("238,569");
            decimal c = decimal.Parse("124,457");
            byte d = byte.Parse("4");
            Console.WriteLine($"a={a} b={b} c={c} d={d}");

            //TryParse
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            bool result = int.TryParse(input, out var number);
            if (result == true)
                Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
            else
                Console.WriteLine("Преобразование завершилось неудачно");
            CultureInfo enUS = new CultureInfo("en-US");
            string dateString;
            DateTime dateValue;

            //TryParseExact
            dateString = " 5/01/2009 8:30 AM";
            if (DateTime.TryParseExact(dateString, "g", enUS,
            DateTimeStyles.None, out dateValue))
                Console.WriteLine("Converted '{0}' to {1} ({2}).", dateString, dateValue,
                dateValue.Kind);
            else
                Console.WriteLine("'{0}' не приемлемый формат.", dateString);
        }

    }
}

