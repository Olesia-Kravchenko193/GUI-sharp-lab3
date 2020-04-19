using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_sharp_lab3
{
    class ComplexNumbers
    {
        const Byte SIZE = 3;

        public ComplexNumber[] numbers = new ComplexNumber[SIZE];
        String[] abc = new String[SIZE] { "a = ", "b = ", "c = " };

        public Int32 printMode = 1;

        Byte currentElement = 0;
        public byte CurrentElement { get => currentElement; }

        public ComplexNumbers()
        {
            for (int i = 0; i < SIZE; i++)
            {
                numbers[i] = new ComplexNumber();
            }
        }

        public void SetElement(Double real, Double imagine, Int32 choice)
        {
            if (currentElement >= SIZE)
                currentElement = 0;

            numbers[currentElement++] = new ComplexNumber(real, imagine, choice);
        }

        public override string ToString()
        {
            String infLine = "";

            for (int i = 0; i < SIZE; i++)
            {
                numbers[i].Pr = printMode;
                infLine += abc[i] + numbers[i].ToString();
            }

            return infLine;
        }
    }
}
