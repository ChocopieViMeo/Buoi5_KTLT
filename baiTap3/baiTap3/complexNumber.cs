using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap3
{
    internal class complexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public complexNumber( double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static complexNumber operator + (complexNumber a, complexNumber b)
        {
            return new complexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }
        public static complexNumber operator - (complexNumber a, complexNumber b )
        {
            return new complexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        public static complexNumber operator * (complexNumber a, complexNumber b)
        {
            return new complexNumber(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + b.Real * a.Imaginary);
        }
        public static complexNumber operator /(complexNumber a, complexNumber b)
        {
            double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
            return new complexNumber((a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator,
                               (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator);
        }
        public override string ToString()
        {
            return $"{Real:F2} + {Imaginary:F2} ";
        }

    }
}
