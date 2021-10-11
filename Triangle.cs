using System;
namespace Task1
{
    class Triangle

    {

        public Triangle(double a)

        {
            this.a = a;
            this.b = a;
            this.c = a;
        }


        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        

        public double Perimeter()
        {
            return (a+b+c);
        }

        
        public double AngleA()
        {

            double A = (Math.Acos((((-a) * a) + (b * b) + (c * c)) / (2 * b * c)))*57.29577951308232;
            return  A;            

        }

        public double AngleB()
        {
            double B = (Math.Acos((((-b) * b) + (a * a) + (c * c)) / (2 * a * c))) * 57.29577951308232;
            return B;
        }


        public double AngleC()
        {
           
            double C = (Math.Acos((((-c) * c) + (b * b) + (a * a)) / (2 * b * a))) * 57.29577951308232;
            return C;
        }

        public void setSide(UInt16 length, double newSide)
        {
            if (length == 1) this.a = newSide;
            else if (length == 2) this.b = newSide;
            else if (length == 3) this.c = newSide;
            else throw new Exception("Invalid side number:(");
        }

        public double a;
        public double b;
        public double c;

    }

    class EquilTriangle : Triangle


    {
        public EquilTriangle(double a) : base(a)

        {
            area = (a * a * Math.Sqrt(3)) / 4;
        }

        public double Area()
        {
            return area;
        }

        private double area;
    }
}