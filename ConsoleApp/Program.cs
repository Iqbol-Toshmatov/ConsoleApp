using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal dog=new Dog("Buddy");
            dog.Sound();

            Transport plane = new Plane();
            plane.Move();

            Shape rectangle=new Rectangle(5, 10);

            var perimeter = rectangle.GetPerimeter();
            Console.WriteLine("Perimeter of rectangle : " + perimeter);

            var area = rectangle.GetArea();
            Console.WriteLine("Area of rectangle : " + area);

        }
    }

    // Абстрактный класс Animal представляет животное с именем и методом Sound
    public abstract class Animal
    {

        // Свойство для хранения имени животного
        public string Name { get; set; }


        // Конструктор, инициализирующий имя животного
        protected Animal(string name)
        {
            Name = name;
        }


        // Метод для вывода звука животного (может быть переопределён в наследниках)
        public void Sound()
        {
            Console.WriteLine($"{Name}'s sound");
        }
    }

    // Класс Dog наследует Animal и реализует конструктор
    public class Dog : Animal
    {

        // Конструктор принимает имя и передает его базовому классу Animal
        public Dog(string name) : base(name)
        {
        }

    }

    // Абстрактный класс Transport определяет общий интерфейс для транспорта
    public abstract class Transport
    {

        // Абстрактный метод Move должен быть реализован в наследниках
        public abstract void Move();
    }

    // Класс Plane наследует Transport и реализует метод Move
    public class Plane : Transport
    {

        // Реализация метода Move для самолета
        public override void Move()
        {
            Console.WriteLine("Plane is flying");
        }
    }


    // Абстрактный класс Shape определяет интерфейс для геометрических фигур
    public abstract class Shape
    {
        // Абстрактный метод для вычисления периметра фигуры
        public abstract double GetPerimeter();

        // Абстрактный метод для вычисления площади фигуры
        public abstract double GetArea();
    }

    // Класс Rectangle реализует фигуру прямоугольник
    public class Rectangle : Shape
    {
        // Свойство высоты прямоугольника
        public double Height { get; set; }
        // Свойство ширины прямоугольника
        public double Width { get; set; }

        // Конструктор принимает высоту и ширину прямоугольника
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        // Переопределение метода для вычисления периметра прямоугольника
        public override double GetPerimeter()
        {
            return 2 * (Height + Width);
        }

        // Переопределение метода для вычисления площади прямоугольника
        public override double GetArea()
        {
            return Height * Width;
        }
    }


}


