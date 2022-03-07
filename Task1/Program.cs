using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату правонарушения:");
            var dt = DateTime.Parse(Console.ReadLine());
            var dtn = DateTime.Now;
            var time = (dtn - dt).Ticks;

            
            Console.WriteLine($"{time}");
        }
    }
}
