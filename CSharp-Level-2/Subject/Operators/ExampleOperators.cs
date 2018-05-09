using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_2.Subject.Operators
{
    class ExampleOperators
    {
        public void Test(string line)
        {
            var arr = line.Split(' ');
            double param1 = Convert.ToDouble(arr[0]);
            double param2 = Convert.ToDouble(arr[2]);
            IOperations oper = null;
            if (arr[1] == "+")
                oper = new Plus();
            else if (arr[1] == "-")
                oper = new Minus();
            else if (arr[1] == "*")
                oper = new Multi();
            else if (arr[1] == "/")
                oper = new Divi();
            Calculator.Calculate(param1, oper, param2);
        }
    }

    class Calculator
    {
        public static void Calculate(double param1, IOperations oper, double param2)
        {
            Console.WriteLine($"Result: {oper.Calculate(param1, param2)}");
        }
    }

    interface IOperations
    {
        double Calculate(double param1, double param2);
    }

    class Plus : IOperations
    {
        public double Calculate(double param1, double param2)
        {
            return param1 + param2;
        }
    }

    class Minus : IOperations
    {
        public double Calculate(double param1, double param2)
        {
            return param1 - param2;
        }
    }

    class Multi: IOperations
    {
        public double Calculate(double param1, double param2)
        {
            return param1 * param2;
        }
    }

    class Divi : IOperations
    {
        public double Calculate(double param1, double param2)
        {
            if (param2 != 0)
                return param1 / param2;
            else
                return 0;
        }
    }


}
