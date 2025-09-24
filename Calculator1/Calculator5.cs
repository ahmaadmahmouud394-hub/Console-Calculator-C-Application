using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;


public class Calculator5
    {       
        private readonly ICalcolo _calcolo;

        public Calculator5(ICalcolo calcolo) 
        {
             
             _calcolo = calcolo;
        
        }

        public double Sum(int Num1, int Num2)
        {
            return (_calcolo.Sum(Num1, Num2));
        }
        public double Diffrence(int Num1, int Num2)
        {
            return (_calcolo.Diffrence(Num1, Num2));
        }
        public double Multiplication(int Num1, int Num2)
        {

            return (_calcolo.Multiplication(Num1, Num2));
        }
        public double Division(int Num1, int Num2)
        {
            return (_calcolo.Division(Num1, Num2));
        }
    }

