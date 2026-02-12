using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicConceptsPractice
{
    internal class Calculation
    {
        private double _firstnum;
        public double FirstNumber
        {
            get
            {

                return _firstnum;
            }
            set
            {
                _firstnum = value;

            }
        }
        private char _operat;
        public char Operation
        {
            get
            {
                return _operat;
            }
            set
            {
                if ("+,-,*,/".Contains(value))
                    _operat = value;
                else
                    Console.WriteLine("duzgun operatoru sechin: +, -, *, /");
            }
        }

        private double _secondnum;
        public double SecondNumber
        {
            get
            {

                return _secondnum;
            }
            set
            {
                _secondnum = value;

            }
        }

        public Calculation(double firstNum, double secondNum, char @operator)
        {
            FirstNumber = firstNum;
            SecondNumber = secondNum;
            Operation = @operator;
        }

        public void Calculate()
        {
            switch (Operation)
            {
                case '+':
                    Console.WriteLine(FirstNumber + SecondNumber);
                    break;
                case '-':
                    Console.WriteLine(FirstNumber - SecondNumber);
                    break;
                case '*':
                    Console.WriteLine(FirstNumber * SecondNumber);
                    break;
                case '/':
                    if(FirstNumber /  SecondNumber == 0) Console.WriteLine("ededlerden bi 0 olduguna gore ve 0 a bolunme olmadigina gore bolunme ugursuzdur");
                    else Console.WriteLine(FirstNumber / SecondNumber); 
                    break;
                default: Console.WriteLine("operatoru duzgun daxil edin");
                    break;
            }
        }
    }
}
