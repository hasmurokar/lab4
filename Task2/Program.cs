using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            var array = new CityBuild[4];
            for (int i = 1; i <= array.Length; i++)
            {
                var cName = "Building " + i;
                var bObject = "Object " + i;
                var square = rnd.Next(20, 100);
                var sDate = RandomDay();
                var eDate = RandomDay().AddYears(rnd.Next(5, 7));
                //var eDate = new DateTime(2022, 9, 7);
                var state = "No Info";
                array[i - 1] = new CityBuild(cName, bObject, square, sDate, eDate, state);
            }
            Console.WriteLine("Название     |Объект        |Площадь   |Дата начала |Дата окончания|Состояние   | Остаток дней");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();


            var newArray = array.Where(a => IsEndFourQurtal(a.EndDate)).ToArray();
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            if (newArray.Length == 0)
            {
                Console.WriteLine("Список пуст.");
            }
        }
        public static DateTime RandomDay()
        {
            var start = new DateTime(2018, 1, 1);
            var range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public static bool IsEndFourQurtal(DateTime endDate)
        {
            var startQ = new DateTime(2022, 10, 1);
            var endQ = new DateTime(2022, 12, 31);
            if (endDate > startQ && endDate < endQ)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
