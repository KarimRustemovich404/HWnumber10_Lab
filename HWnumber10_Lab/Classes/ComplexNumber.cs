using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWnumber10_Lab.Classes
{
    internal class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexNumber()
        {

        }

        public static ComplexNumber operator +(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            ComplexNumber complexNumber3 = new ComplexNumber();
            complexNumber3.Real = complexNumber1.Real + complexNumber2.Real;
            complexNumber3.Imaginary = complexNumber1.Imaginary + complexNumber1.Imaginary;


        } 
        
    }
}
