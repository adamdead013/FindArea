namespace FindArea
{
    public class Figures //базовый класс
    {
        public virtual double GetArea()
        {
            return 1;
        }
        public virtual double GetArea(double radius)
        {
            return radius;
        }
        public virtual double GetArea(double a, double b, double c)
        {
            return 1;
        }
    }
    public class Circle : Figures //площадь круга
    {
        public override double GetArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    public class Triangle : Figures //площадь треугольника
    {
        public override double GetArea(double a, double b, double c)
        {
            double semiPerimetr = (a + b + c) / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - a) * (semiPerimetr - b) * (semiPerimetr - c));
        }
        public bool IsRectangular(double a, double b, double c)
        {
            double maxValue = Math.Max(Math.Max(a, b),c);
            return Math.Pow(maxValue,2) == Math.Pow((a + b + c),2) - Math.Pow(maxValue,2);
        }
    }
}