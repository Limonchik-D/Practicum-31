using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__31
{
    class Rectangle : Figure //Прямоугольник
    {
        protected double side1; //Сторона 1 
        protected double side2; //Сторона 2

        /// <summary>
        /// Конструктор с параметрами
        public Rectangle( double side1, double side2) : base ("Прямоугольник")  
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        /// <summary>
        /// Свойство для доступа к полю side1
        public double Side1
        {
            get { return side1; }
            set { side1 = value;}
        }
        /// <summary>
        ///Свойство для доступа к полю side2
        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }
        /// <summary>
        /// Метод возвращающий площадь прямоугольника по его сторонам;
        public override double Area()
        {
            return side1 * side2;
        }
        /// <summary>
        /// Периметр прямоугольника
        public override double Perimeter()
        {
            return (side1 + side2) * 2;
        }
        /// <summary>
        /// Метод для вывода информации о фигуре
        public override void Print()
        {
            Console.WriteLine($"Фигура: {Name}, Cторона 1: {Side1}, Сторона 2: {Side2} Площадь: {Area()}, Периметр: {Perimeter()}");
        }


    }
}
