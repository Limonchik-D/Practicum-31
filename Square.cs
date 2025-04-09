using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__31
{
    internal class Square : Figure //Класс квадрат
    {
        private double side; //Сторона

        public Square(double side) : base ("Квадрат") //Конструктор с параметрами
        {
            this.side = side;
        }

        public double Side //Свойство для доступа к полю side  
        {
            get { return side; }
            set { side = value; }
        }

        public override double Area() //Метод для вычисления площади квадрата
        {
            return side * side;
        }

        public override double Perimeter() //Метод для вычисления периметра квадрата
        {
            return 4 * side;
        }

        public override void Print()
        {
            Console.WriteLine($"Фигура: {Name}, сторона: {Side}, Площадь: {Area()},  Периметр: {Perimeter()}");
        }


    }
}
