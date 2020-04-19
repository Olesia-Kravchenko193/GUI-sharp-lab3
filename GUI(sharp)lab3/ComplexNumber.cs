using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_sharp_lab3
{
    class ComplexNumber
    {
        Double real;
        Double imagine;

        Int32 pr;

        const Double RAD_TO_DEGREE = 180 / Math.PI;
        const Double DEGREE_TO_RAD = Math.PI / 180;

        public Int32 Pr { get => pr; set => pr = (value <= 1 && value >= 0) ? value : 1; }

        public ComplexNumber(Double real = 1, Double imagine = 1, Int32 choice = 1)
        {
            Pr = choice;

            if (Pr == 1)
            {
                this.real = real;
                this.imagine = imagine;
            }
            else
            {
                this.real = real * Math.Cos(imagine * DEGREE_TO_RAD);
                this.imagine = real * Math.Sin(imagine * DEGREE_TO_RAD);
            }
        }

        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.real + num2.real, num1.imagine + num2.imagine);
        }

        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.real - num2.real, num1.imagine - num2.imagine);
        }

        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.real * num2.real - num1.imagine * num2.imagine,
                num1.real * num2.imagine + num1.imagine * num2.real);
        }

        public static ComplexNumber operator /(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber((num1.real * num2.real + num1.imagine * num2.imagine) /
                (num2.real * num2.real + num2.imagine * num2.imagine),
                (num2.real * num1.imagine - num1.real * num2.imagine) /
                (num2.real * num2.real + num2.imagine * num2.imagine));
        }

        public override string ToString()
        {
            if (pr == 1)
                return $"{Math.Round(real)} + {Math.Round(imagine)}*i\n";
            else
            {
                Double r = Math.Sqrt(real * real + imagine * imagine);
                return $"{Math.Round(r)}*(cos({Math.Round(Math.Acos(real / r) * RAD_TO_DEGREE)}°) + sin({Math.Round(Math.Acos(real / r) * RAD_TO_DEGREE)}°)*i)\n";
            }
        }
    }
}
