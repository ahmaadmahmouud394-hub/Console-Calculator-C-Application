using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Moq;

public class Calcolo : ICalcolo
    {
        public double Sum(int Num1, int Num2)
        {
            double sum = 0;
            sum = Num1 + Num2;
            return sum;
        }
        public double Diffrence(int Num1, int Num2)
        {
            double Diffrence = 0;
            Diffrence = Num1 - Num2;
            return Diffrence;
        }
        public double Multiplication(int Num1, int Num2)
        {
            double Multiplication = 0;
            Multiplication = Num1 * Num2;
            return Multiplication;
        }
        public double Division(int Num1, int Num2)
        {
            double Division = 0;
            Division = Num1 / Num2;
            return Division;
        }

    }

