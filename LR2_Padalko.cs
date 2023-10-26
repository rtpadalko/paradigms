using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace Figures
{
    //Интерфейс
    interface IPrint 
    { 
        void Print(); 
    }

    //Абстрактный класс фигуры
    abstract class Figure
    {
        string T;

        //Тип фигуры
        public string Type
        {
            get { return this.T; }
            
            protected set { this.T = value; }
        }
        //чистый вирутальный метод вычисления площади фигуры
        public abstract double Area();

        //переопределение метода Object
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }

        public void Print() 
        {
            Console.WriteLine(this.ToString()); 
        }
    }

    class Rectangle : Figure
    {
        //высота
        double width { set; get; }
        //ширина
        double height { set; get; }

        private string _property1; //опорная переменная
        public string property //ярлык на две методы
        {
            get { return this._property1; }
            set { this._property1 = value; }
        }
        //конструктор
        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
            this.Type = "Прямоугольник";
        }

        //виртуальный метод площади прямоугольника
        public override double Area()
        { 
                double result = this.width* this.height;
            return result;
        }
        //переопределение метода Object для прямоугольника
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Square : Rectangle
    {
        public Square(double size) : base(size, size) //base(size, size) - вызов конструктора базового класса
        {
            this.Type = "Квадрат";
        }
        //так как класс квадрат относится к классу прямоугольник,
        //следовательно в этом классе описывается только конструктор
    }

    class Circle : Figure
    {
        double radius { set; get; }

        private string _property2; //опорная переменная
        public string property //ярлык на две методы
        {
            get { return this._property2; }
            set { this._property2 = value; }
        }
        public Circle(double r)
        {
            this.radius = r;
            this.Type = "Круг";
        }
        //виртуальный метод площади круга
        public override double Area()
        {
            double Result = Math.PI * this.radius * this.radius;
            return Result;
        }
        //переопределение метода Object для круга
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
        
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    //Основная программа
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 7);
            Square square = new Square(9);
            Circle circle = new Circle(2);
            Rectangle rectangle1 = new Rectangle(4, 5);
            Square square1 = new Square(3);
            Circle circle1 = new Circle(1);
            rectangle.Print();
            square.Print();
            circle.Print();
            rectangle1.Print();
            square1.Print();
            circle1.Print();
            Console.ReadLine();
        }
    }
}