using System;

namespace Homework_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1) Написать программу, которая будет спрашивать имя и возраст двух человек, после чего спросит, 
              человек с каким именем старше?(одно из ранее введенных). После ввода имени,
              программа должна вывести ответ,правильно или не правильно, и написать, кто старше, и на сколько. 
              Предусмотреть ввод невалидных данных, и повторное отображение вопроса с повторным вводом при вводе невалидных данных.*/

            int age1 = 0;
            int age2 = 0;
            string name1;
            string name2;
            string name;
                                           
           
                Console.WriteLine("Введите своё имя:");
                name1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите свой возраст:");
                age1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите имя вашего друга :");
                name2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите возраст вашего друга:");
                age2 = Convert.ToInt32(Console.ReadLine());
           
            do
            {
                Console.WriteLine("Кто старше?");
                name = Console.ReadLine();

                if ((name == name1) && (age1 > age2))
                {
                    Console.WriteLine($"Ответ верный {name1} старше {name2} на {age1 - age2}.");
                    break;
                }

                else if ((name == name2) && (age2 > age1))
                {
                    Console.WriteLine($"Ответ верный {name2} старше {name1} на {age2 - age1}.");
                    break;
                }

                else if ((name == name2) && (age2 == age1))
                {
                    Console.WriteLine($"{name2} и {name1} являются ровесниками.");
                    break;
                }

                else if ((name == name1) && (age1 < age2))
                {
                    Console.WriteLine($"Ответ неверный. {name1} не старше {name2}.");
                }

                else if ((name == name2) && (age2 < age1))
                {
                    Console.WriteLine($"Ответ неверный. {name2} не старше {name1}.");
                }

                else if ((name != name1) && (name != name2))
                {
                    Console.WriteLine("Повторите попытку снова");
                    continue;
                }


            } while ((name != name1) || (name != name2));


            





        }
    }
}
