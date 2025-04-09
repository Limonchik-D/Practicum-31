using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__31
{
    internal class Circle : Figure //Круг
    {
        public double radius; //Радиус
        public double Radius //Свойство для доступа к полю radius
        {
            get { return radius; }
            set { radius = value; }
        }
        //  public Circle(string name, double radius) : base(name) //Конструктор с параметрами
        public Circle(double radius) : base("Круг") //Конструктор с параметрами      
        {
            this.radius = radius;
        }
        public override double Area() //Метод для вычисления площади круга
        {
            return Math.PI * radius * radius;
        }
        public override double Perimeter() //Метод для вычисления периметра круга
        {
            return 2 * Math.PI * radius;
        }

        public override void Print() //Метод для вывода информации о фигуре
        {
            Console.WriteLine($"Фигура: {Name}, Радиус: {Radius}, Площадь: {Math.Round(Area(), 2)}, Периметр: {Math.Round(Perimeter(), 2)}");
        }
    }
}
