using System;

namespace Homework_3._Metod
{
    class Program
    {

        /*1) Написать программу, которая будет спрашивать имя и возраст двух человек, после чего спросит, 
              человек с каким именем старше?(одно из ранее введенных). После ввода имени,
              программа должна вывести ответ,правильно или не правильно, и написать, кто старше, и на сколько. 
              Предусмотреть ввод невалидных данных, и повторное отображение вопроса с повторным вводом при вводе невалидных данных.*/

        static void Main(string[] args)
        {
            Info();
        }


        public static void Info()
        {

            Console.WriteLine("Введите своё имя:");
            string name1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите свой возраст:");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите имя вашего друга :");
            string name2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите возраст вашего друга:");
            int age2 = Convert.ToInt32(Console.ReadLine());

            string name = "";

            Vibor(name, name1, name2, age1, age2);
        }

        public static void Vibor(string name, string name1, string name2, int age1, int age2)
        {
            Console.WriteLine("Кто старше?");
            name = Console.ReadLine();
            Proverka(name, name1, name2, age1, age2);
        }

        public static void Proverka(string name, string name1, string name2, int age1, int age2)
        {

            if ((name != name1) && (name != name2))
            {
                Console.WriteLine("Повторите попытку снова.");
                Vibor(name, name1, name2, age1, age2);
            }

            else
            {
                Otvet(name, name1, name2, age1, age2);
            }

        }
        public static void Otvet(string name, string name1, string name2, int age1, int age2)
        {


            if ((name == name1) && (age1 > age2))
            {
                Console.WriteLine($"Ответ верный {name1} старше {name2} на {age1 - age2}.");

            }

            else if ((name == name2) && (age2 > age1))
            {
                Console.WriteLine($"Ответ верный {name2} старше {name1} на {age2 - age1}.");

            }

            else if ((name == name1) && (age1 == age2))
            {
                Console.WriteLine($"{name1} и {name2} являются ровесниками.");

            }

            else if ((name == name2) && (age1 == age2))
            {
                Console.WriteLine($"{name2} и {name1} являются ровесниками.");

            }

            else if ((name == name1) && (age1 < age2))
            {
                Console.WriteLine($"Ответ неверный. {name1} не старше {name2}.");
            }

            else if ((name == name2) && (age2 < age1))
            {
                Console.WriteLine($"Ответ неверный. {name2} не старше {name1}.");
            }
        }
    }
}
