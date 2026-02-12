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
            switch (_operat)
            {
                case '+':
                    Console.WriteLine(_firstnum + _secondnum);
                    break;
                case '-':
                    Console.WriteLine(_firstnum - _secondnum);
                    break;
                case '*':
                    Console.WriteLine(_firstnum * _secondnum);
                    break;
                case '/':
                    if (_firstnum != 0 && _secondnum != 0)
                        Console.WriteLine(_firstnum / _secondnum);
                    else Console.WriteLine("0 a bolunme yoxdur");
                    break;
                
            }
        }
    }
}
