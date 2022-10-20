using System;

namespace CalculatorV2
{
    class Calculator
    {
        public Calculator(double a, double b)
        {

        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            try
            {
                double c = a / b;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error");
            }

            return 0;
            
        }

        public double Square(double a)
        {
            return Convert.ToDouble(Math.Pow(a, 2));
        }

        public double Squareroot(double a)
        {
            return Convert.ToDouble(Math.Sqrt(a));
        }

        public double Cube(double a)
        {
            return Convert.ToDouble(Math.Pow(a, 3));
        }

        public double Cuberoot(double a)
        {
            return Convert.ToDouble(Math.Cbrt(a));
        }

        public double Log10(double a)
        {
            return Convert.ToDouble(Math.Log10(a));
        }
    }
    
    class Program
    {
        static void Main(string[] args)
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
            

            double ch = Double.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator Calc = new Calculator(a, b);
                    c = Calc.Add(a, b);
                    Console.WriteLine("Answer = {0}", c);
                    break;
                case 2:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator Calc2 = new Calculator(a, b);
                    c = Calc2.Subtract(a, b);
                    Console.WriteLine("Answer = {0}", c);
                    break;
                case 3:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator Calc3 = new Calculator(a, b);
                    c = Calc3.Multiply(a, b);
                    Console.WriteLine("Answer = {0}", c);
                    break;
                case 4:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator Calc4 = new Calculator(a, b);
                    c = Calc4.Divide(a, b);
                    Console.WriteLine("Answer = {0}", c);
                    break;
                case 5:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = 0;
                    Calculator Calc5 = new Calculator(a, b);
                    c = Calc5.Square(a);
                    Console.WriteLine("Answer = {0}", c);
                    break;
                case 6:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = 0; 

                    Calculator Calc6 = new Calculator(a, b);
                    c = Calc6.Squareroot(a);
                    Console.WriteLine("Answer = {0}", c);
                    break;
                case 7:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = 0;

                    Calculator Calc7 = new Calculator(a, b);
                    c = Calc7.Cube(a);
                    Console.WriteLine("Answer = {0}", c);
                    break;
                case 8:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = 0;

                    Calculator Calc8 = new Calculator(a, b);
                    c = Calc8.Cuberoot(a);
                    Console.WriteLine("Answer = {0}", c);
                    break;
                case 9:
                    Console.Write("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = 0;

                    Calculator Calc9 = new Calculator(a, b);
                    c = Calc9.Log10(a);
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
