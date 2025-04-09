using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__31
{
    class Program
    {
        static List<Figure> figures = new List<Figure>();
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>(); 

            figures.Add(new Circle(5)); //Добавляем круг с радиусом 5
            //figures.Add(new Circle(Круг, 5)); //Добавляем круг с радиусом 5
            figures.Add(new Rectangle(4, 5)); //Добавляем прямоугольник со сторонами 4 и 5
            figures.Add(new Square(4)); //Добавляем квадрат со стороной 4
            figures.Add(new Triangle(4, 5, 6)); //Добавляем треугольник со сторонами 4, 5 и 6

            foreach (Figure figure in figures) //Перебираем все фигуры в списке
            {
                figure.Print(); //Выводим информацию о фигуре
                Console.WriteLine();
            }
            Console.ReadLine();

            
        }
    }
}