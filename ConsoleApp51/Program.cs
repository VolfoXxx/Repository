using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            string c = "";
             
            try
            {
                Console.WriteLine("Введите первое число");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите знак +, -, /, *");
                c = Console.ReadLine();

                switch (c)
                {
                    case "+":
                        double s1 = a + b;
                        Console.WriteLine($"Результат равен - {s1}");
                        break;

                    case "-":
                        double s2 = a - b;
                        Console.WriteLine($"Результат равен - {s2}");
                        break;

                    case "*":
                        double s3 = a * b;
                        Console.WriteLine($"Результат равен - {s3}");
                        break;

                    case "/":
                        double s4 = a / b;
                        Console.WriteLine($"Результат равен - {s4}");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено не число");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на ноль");
            }
            Console.ReadKey();
        }
    }
}
