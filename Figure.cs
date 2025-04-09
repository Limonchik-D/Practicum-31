using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum__31
{
    abstract class Figure //Абстрактный класс Фигура
    {
        private string name; //Название фигуры

        /// <summary>
        /// Свойство Name для достпуа к полю name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="name"></param>
        public Figure(string name)
        {
            this.name = name;
            
        }
        abstract public double Area(); //Абстрактный метод для вычисления площади фигуры
        abstract public double Perimeter(); //Абстрактный метод для вычисления периметра фигуры

        /// <summary>
        /// Метод для вывода информации о фигуре
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine($"Фигура: {Name}");
        }
    }
}
