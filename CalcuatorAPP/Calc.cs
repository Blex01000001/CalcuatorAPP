using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalcuatorAPP
{
    internal class Calc
    {
        private double _number1;
        public string Number1
        {
            get
            {
                return _number1.ToString();
            }
            set
            {
                double.TryParse(value, out _number1);
            }
        }
        private double _number2;
        public string Number2
        {
            get
            {
                return _number2.ToString();
            }
            set
            {
                double.TryParse(value, out _number2);
            }
        }
        private string _opers;
        public string Operators { get { return _opers; } set { _opers = value; } }

        public string Result()
        {
            //Assembly assembly = Assembly.GetExecutingAssembly();  // 程序集

            //Type type = assembly.GetType($"Calculator.{Operators}");
            //Type type = assembly.GetType($"Calculator.Operators.{Operators}");
            //Type type = assembly.GetType($"CalcuatorAPP.Calculator.{Operators}");
            //Type type = assembly.GetType($"CalcuatorAPP.{Operators}");
            //Type type = assembly.GetType(Operators);
            //Calculation cal = (Calculation)Activator.CreateInstance(type, _number1, _number2);
            //return cal.Result();
            return CalculateFactory.CreateCalculation(_number1, _number2, Operators).Result();
        }
    }
}
