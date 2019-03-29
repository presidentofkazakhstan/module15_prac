using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace module15_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание");
            Type type = typeof(List<>);
            ConstructorInfo[] constructors = type.GetConstructors();
            Console.WriteLine("Конструкторы List<>: ");
            foreach (var construct in constructors)
            {
                Console.WriteLine(construct.ToString());
            }
            Console.WriteLine(" ");
            Console.WriteLine("Второе задание");
            Console.Write("Введите от какого числа начинается ваша подстрока: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите размер подстроки: ");
            int finish = int.Parse(Console.ReadLine());
            char[] name = new char[100];
            Console.Write("Введите имя: ");
            String text = Console.ReadLine();
            name = text.ToCharArray();
            Type secondtype = text.GetType();
            object valid = Activator.CreateInstance(secondtype, new Object[] { name, start, finish });
            Console.WriteLine(valid);
            Console.Read();
            Console.Read();
        }
    }
}
