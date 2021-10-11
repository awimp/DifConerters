using System;
namespace DZ
{
    public class ClassConverter
    {

        static public void RealizClassConverter()
        {

            {

                Console.WriteLine("CONVERTER MODE ON");

                double dollars = 0;
                double euros = 0;
                


                Console.WriteLine("If you want to convert GRIVNAS to OTHER currency ENTER 'G'. \nIf you want to convert OTHER currency TO GRIVNAS ENTER 'O' ");

                char operation = Convert.ToChar(Console.ReadLine());

                

                if (operation == 'G')


                {
                    Console.WriteLine("To what currency do you want to convert grivnas? Type 'e' for euro, 'd' for dollars");
                    char operation2 = Convert.ToChar(Console.ReadLine());
                    


                    if (operation2 == 'd')


                    {
                        Console.WriteLine("Enter the number you want to convert");
                        double grivnas = Convert.ToDouble(Console.ReadLine());

                        var converter = new Converter();

                        Console.WriteLine(grivnas + " grivnas is " + converter.CToDollars(grivnas) + " dollars");

                    }


                    else if (operation2 == 'e')



                    {
                        Console.WriteLine("Enter the number you want to convert");
                        double grivnas = Convert.ToDouble(Console.ReadLine());
                        var converter = new Converter();

                        Console.WriteLine(grivnas + " grivnas is " + converter.CToEuros(grivnas) + " euros");

                    }


                    else Console.WriteLine("Incorrect value, try again");
                }



                else if (operation == 'O')


                {
                    Console.WriteLine("What currency do you want to convert to grivnas? Type 'e' for euro, 'd' for dollars");
                    char operation3 = Convert.ToChar(Console.ReadLine());


                    if (operation3 == 'd')

                    {
                        Console.WriteLine("Enter the number you want to convert");
                        dollars = Convert.ToDouble(Console.ReadLine());
                        var converter = new Converter();

                        Console.WriteLine(dollars + " dollars is " + converter.CDollars(dollars) + " grivnas");

                    }


                    else if (operation3 == 'e')

                    {
                        Console.WriteLine("Enter the number you want to convert");
                        euros = Convert.ToDouble(Console.ReadLine());
                        var converter = new Converter();

                        Console.WriteLine(euros + " euros is " + converter.CEuros(euros) + " grivnas");

                    }


                    else Console.WriteLine("Incorrect value, try again");
                }



                else Console.WriteLine("Incorrect value, try again");

                             
            }
        }
    }

}