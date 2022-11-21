using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using ;

namespace _301.Практическая_2
{
    class User
    {
        public string login, password, second_name, first_name;

        public void Authorize()
        {
            Console.WriteLine("Enter your login");
            string login1 = Console.ReadLine();

            Console.WriteLine("Enter your password");
            string password1 = Console.ReadLine();



            if (login == login1 && password == password1)
            {
                Console.WriteLine($"Your name is - {first_name}\nYour second name is - {second_name}.");
                Program program = new Program();
                program.Middle();
            }
            else
            {
                Console.WriteLine("Your password or login is wrong. Please enter your password and login again");
                Authorize2();
            }
        }
        private void Authorize2()
        {
            Authorize();
        }
    }

    class Program
    {
        static int a, b;

        static void Begin()
        {
            Console.WriteLine("Enter 1(+), 2(-), 3(*) or 4(/)");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine("a minus b equals to - " + Plus(a, b));
            }
            else if (c == 2)
            {
                Console.WriteLine("a minus b equals to - " + Minus(a, b));
            }
            else if (c == 3)
            {
                _301.Библиотека.Person
            }
            else if (c == 4)
            { }
            else
            {
                Console.WriteLine("You entered wrong character, please enter 1(+), 2(-), 3(*) or 4(/)");
                End();
            }
        }

        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static void End() 
        {
            Begin();
        }

        public void Middle()
        {
            Console.WriteLine($"Enter the number - ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the number - ");
            b = Convert.ToInt32(Console.ReadLine());

            Begin();
        }
        static void Main(string[] args)
        {
            User user = new User();
            user.Authorize();
        }
    }
}
