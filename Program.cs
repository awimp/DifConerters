using System;


namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first side: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second side: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third side: ");
            double c = Convert.ToDouble(Console.ReadLine());


            //var eqTr = new EquilTriangle(3);
            var triangle = new Triangle(a,b,c);
            //Console.WriteLine(eqTr.Perimeter());
            Console.WriteLine("\nPerimeter of this triangle is " + triangle.Perimeter() +"\n");

            Console.WriteLine("If you want to calculate angles type 'y'\n");

            char examination = Convert.ToChar(Console.ReadLine());


            if (examination == 'y')
            {
                Console.WriteLine("The angle A is " + triangle.AngleA() + "\n");
                

                Console.WriteLine("The angle B is " + triangle.AngleB() + "\n");
                

                Console.WriteLine("The angle C is " + triangle.AngleB() + "\n");
               
            }

            
        }
    }
}