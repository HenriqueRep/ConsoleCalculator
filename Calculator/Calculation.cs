using System;
using System.Text;

namespace Calculator
{
    public class Calculation
    {
        public double Number1 { get; set; }
        public string Operation { get; set; }
        public double Number2 { get; set; }

        public Calculation(double number1, string operation, double number2)
        {
            Number1 = number1;
            Operation = operation;
            Number2 = number2;
        }

        public double Result()
        {
            double result = 0;
            switch (Operation)
            {
                case "+": result = Number1 + Number2; break;
                case "-": result = Number1 - Number2; break;
                case "*": result = Number1 * Number2; break;
                case "/": result = Number1 / Number2; break;
                case "l": result = Math.Log10(Number1) ; break;
                case "r": result = Math.Sqrt(Number1); break;
                case "i": result = Math.Pow(Number1, Number2); break;
            }
            return result;
        }

        public override string ToString()
        {
            return Number1.ToString("0.#####") + Operation.ToString() + Number2.ToString() + "=";
        }
    }
}
