using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    /*
     Практическое задание для Mindbox
    Задание:

    Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

    Юнит-тесты:
    Написаны тесты для расчётов площади круга и треугольника, а также для проверки, на то, прямоугольный ли треугольник

    Легкость добавления других фигур
    Для добавления новой фигуры необходимо создать новый класс и унаследовать класс Figure

    Вычисление площади фигуры без знания типа фигуры в compile-time
    Для этого необходимо использовать статический метод CalculateFigureArea класса Figure

    Проверку на то, является ли треугольник прямоугольным 
    Свойство IsRectangular определяет, прямоугольный ли треугольник
     */
    public abstract class Figure
    {
        public abstract double CalculateArea();
        public static double CalculateFigureArea(Figure figure)
        {
            return figure.CalculateArea();
        }
    }
    public class Triangle : Figure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public bool IsRectangular
        {
            get
            {
                return ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A));
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || b < 0) throw new ArgumentException("Длины сторон не могут быть меньше нуля");
            else if (a > (b + c) || b > (a + c) || c > (a + b)) throw new ArgumentException("Длина одной стороны не может быть больше, чем сумма длин двух других сторон");
            else
            {
                A = a;
                B = b;
                C = c;
            }
        }
        public override double CalculateArea()
        {
            double p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 1, MidpointRounding.ToZero);
        }

    }
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (Radius < 0) throw new ArgumentException("Радиус окружности не может быть отрицательным");
            else Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
