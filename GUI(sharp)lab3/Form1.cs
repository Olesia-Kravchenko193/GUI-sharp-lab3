using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_sharp_lab3
{
    public partial class Form1 : Form
    {
        ComplexNumbers arrayOfNumbers = new ComplexNumbers();
        ComplexNumber result = new ComplexNumber();
        String taskLine;

        public Form1()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                arrayOfNumbers.SetElement(Double.Parse(RealTextBox.Text), Double.Parse(ImagineTextBox.Text),
                    Int32.Parse(ChoiceBox.Text));
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            CounterLabel.Text = $"Комплексное число № {arrayOfNumbers.CurrentElement}/3";

            RealTextBox.Text = "";
            ImagineTextBox.Text = "";
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                arrayOfNumbers.printMode = Int32.Parse(ChoiceBox.Text);

                result = (arrayOfNumbers.numbers[0] + arrayOfNumbers.numbers[1]) *
                arrayOfNumbers.numbers[2] * arrayOfNumbers.numbers[2] /
                (arrayOfNumbers.numbers[1] - arrayOfNumbers.numbers[0]);

                result.Pr = Int32.Parse(ChoiceBox.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


            taskLine = $"X = ((a + b) * c^2) / (b - a)\nX = {result}";

            taskLine += arrayOfNumbers.ToString();

            OutPutTextBox.Text = taskLine;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
