using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__31
{
    internal class Triangle : Figure //Треугольник
    {
        private double side1; //Сторона 1
        private double side2; //Сторона 2
        private double side3; //Сторона 3

        public double Side1 //Свойство для доступа к полю side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        public double Side2 //Свойство для доступа к полю side2
        {
            get { return side2; }
            set { side2 = value; }
        }
        public double Side3 //Свойство для доступа к полю side3
        {
            get { return side3; }
            set { side3 = value; }
        }

        public Triangle (double side1, double side2, double side3) : base("Треугольник") //Конструктор с параметрами
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double Perimeter() //Метод для вычисления периметра треугольника
        {
            return side1 + side2 + side3;
        }

        public override double Area() //Метод для вычисления площади треугольника
        {
            double p = Perimeter() / 2; //Полупериметр
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)); //Формула Герона
        }

        public override void Print() //Метод для вывода информации о фигуре
        {
            Console.WriteLine($"Фигура: {Name}, Сторона 1: {Side1}, Сторона 2: {Side2}, Сторона 3: {Side3}, Площадь: {Area()}, Периметр: {Perimeter()}");
        }

    }
}
