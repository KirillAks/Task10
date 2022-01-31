using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        //Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
        //Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных.
        //Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
        //Создать объект на основе разработанного класса. Осуществить использование объекта в программе.

        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.WriteLine("Введите целочисленное значение градусов:");
                int gradus = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целочисленное значение минут:");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целочисленное значение секунд:");
                int sec = Convert.ToInt32(Console.ReadLine());
                angle = new Angle(gradus, min, sec);
            }while (angle.positive == false);
            double angleRadians = angle.ToRadians();
            Console.WriteLine("Угол в радианах равен {0}", angleRadians);
            Console.ReadKey();
        }
    }
}
