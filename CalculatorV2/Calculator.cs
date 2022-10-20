using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorV2
{
    //moved class to it's own file
    internal class Calculator
    {
        public Calculator(/*double a, double b*/) //why does the constructor need these parameters?
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
                return c; //I'm sure you wanted to return c here
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error");
            }

            return 0;
        }

        public double Square(double a)
        {
            //return type is already a double
            return /*Convert.ToDouble(*/Math.Pow(a, 2);//);
        }

        public double Squareroot(double a)
        {
            return /*Convert.ToDouble(*/Math.Sqrt(a);//);
        }

        public double Cube(double a)
        {
            return /*Convert.ToDouble(*/Math.Pow(a, 3);//);
        }

        public double Cuberoot(double a)
        {
            return /*Convert.ToDouble(*/Math.Cbrt(a);//);
        }

        public double Log10(double a)
        {
            //is the conversion necessary?
            return /*Convert.ToDouble(*/Math.Log10(a);//);
        }
    }
}