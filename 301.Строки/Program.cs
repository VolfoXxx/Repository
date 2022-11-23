using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301.Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            string ogname = "name";
            string ogsur = "surname";
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию");
            string sur = Console.ReadLine();

            char m = 'm';
            int surint = sur.IndexOf(m);

            bool name1 = string.Equals(ogname, name);

            int local1 = string.CompareOrdinal(ogname, name);
            int local2 = string.CompareOrdinal(ogsur, sur);
            if(local1<0)
            {
                Console.WriteLine("Выбрана неверная раскладка клавиатуры");
            }
            else
            if(local2<0)
            {
                Console.WriteLine("Выбрана неверная раскладка клавиатуры");
            }
            else
            if (!name1)
            {
                Console.WriteLine("Введено неверное имя");
            }
            else
            if (!sur.Contains("surname"))
            {
                Console.WriteLine("Введена неверная фамилия");
            }
            else
            if (surint == 5) 
            {
                Console.WriteLine("Введена верная фамилия");
            }

            /*int compresname = string.CompareOrdinal(name, ogname);
            int compressur = string.CompareOrdinal(sur, ogsur);
            */
            Console.ReadKey();
        }
    }
}
