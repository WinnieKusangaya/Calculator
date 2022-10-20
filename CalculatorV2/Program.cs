using System;

namespace CalculatorV2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine("5.Square");
            Console.WriteLine("6.Squareroot");
            Console.WriteLine("7.Cube");
            Console.WriteLine("8.Cuberoot");
            Console.WriteLine("9.log10");
            Console.WriteLine("Enter Choice(1-9):");
            double a, b, c;

            //always validate your input in case what is entered doesn't make sense
            double ch = Double.Parse(Console.ReadLine());

            //you probably want to declare this just once
            Calculator Calc = new Calculator(/*a, b*/);
            switch (ch)
            {
                case 1:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());//always validate
                    Console.Write("Enter b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    c = Calc.Add(a, b);
                    Console.WriteLine("Answer = {0}", c);
                    break;

                case 2:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    c = Calc.Subtract(a, b);
                    Console.WriteLine("Answer = {0}", c);
                    break;

                case 3:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    //Calculator Calc3 = new Calculator(a, b);
                    c = Calc.Multiply(a, b);
                    Console.WriteLine("Answer = {0}", c);
                    break;

                case 4:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    // Calculator Calc4 = new Calculator(a, b);
                    c = Calc.Divide(a, b);
                    Console.WriteLine("Answer = {0}", c);
                    break;

                case 5:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    // b = 0;
                    //Calculator Calc5 = new Calculator(a, b);
                    c = Calc.Square(a);
                    Console.WriteLine("Answer = {0}", c);
                    break;

                case 6:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = 0;

                    // Calculator Calc6 = new Calculator(a, b);
                    c = Calc.Squareroot(a);
                    Console.WriteLine("Answer = {0}", c);
                    break;

                case 7:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = 0;

                    // Calculator Calc7 = new Calculator(a, b);
                    c = Calc.Cube(a);
                    Console.WriteLine("Answer = {0}", c);
                    break;

                case 8:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = 0;

                    //Calculator Calc8 = new Calculator(a, b);
                    c = Calc.Cuberoot(a);
                    Console.WriteLine("Answer = {0}", c);
                    break;

                case 9:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = 0;

                    //Calculator Calc9 = new Calculator(a, b);
                    c = Calc.Log10(a);
                    Console.WriteLine("Answer = {0}", c);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}