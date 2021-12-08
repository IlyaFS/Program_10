using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Угол: ");
            double gradus = double.Parse(Console.ReadLine());
            Console.Write("Введите Минуты: ");
            double min = double.Parse(Console.ReadLine());
            Console.Write("Введите Секунды: ");
            double sec = double.Parse(Console.ReadLine());
            double rad = (gradus + (min / 60) + (sec / 360)) * Math.PI / 180;
            
            Angle angle = new Angle(rad);

            angle.Run();
            Console.ReadKey();
        }
    }
    class Angle
    {
        double gradus;
        double min;
        double sec;
        public double rad;

        public double Gradus
        {
            set
            {
                if (value < 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение для градусов");
                }
            }
            get
            {
                return gradus;
            }
        }
        public double Min
        {
            set
            {
                if (value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение для минут");
                }
            }
            get
            {
                return min;
            }
        }
        public double Sec
        {
            set
            {
                if (value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение для секунд");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(double r)
        {
            rad = r;
        }
        public void Run()
        {
            Console.WriteLine("Угол в радианах равен {0:0.00}", rad);
        }
    }
}

// 1.   Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
// Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных.
// Класс должен содержать конструктор для установки начальных значений,а также метод ToRadians для перевода угла в радианы.
// Создать объект на основе разработанного класса.
// Осуществить использование объекта в программе.