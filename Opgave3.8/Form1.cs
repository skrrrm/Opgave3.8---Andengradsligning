using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opgave3._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Variables
        double a, b, c, D, x1, x2, x;

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try // Error text if wrong input on used variables [double]
            {
                a = Convert.ToDouble(textBoxA.Text); // Converts text from textbox to double
                b = Convert.ToDouble(textBoxB.Text); // -----||-----
                c = Convert.ToDouble(textBoxC.Text); // -----||-----
            }
            catch
            {
                labelError.Text = "Only use numbers"; // error label
            }

            if (a == 0 && b == 0 && c == 0) // If a, b and c is all zero.
            {
                labelError.Text = "Zero in all boxes is not an equation, try something else."; // error text in the labe, cause all zeros is not an equation
                textBoxResult.Text = ""; // clears the textbox in case it has the result of a prior calculation
            }
            else if (a == 0 && b != 0) // if a is zero and b is not zero
            {
                x = -c / b; // result assigned to x
                textBoxResult.Text = $"x = {x:F2}"; // write out result with decimals limited to two
            }
            else if (a == 0 && b == 0 && c != 0) // if a and b is zero and c not zero
            {
                labelError.Text = "Try something else."; // error text label
                textBoxResult.Text = ""; // clears the textbox in case it has the result of a prior calculation
            }

            if (a != 0) // if a is not 0
            {
                D = Math.Pow(b, 2) - 4 * a * c; // assigns result of calculation to D

                if (D < 0) // if D is less than zero
                {
                    labelError.Text = "No solution. Try something else."; // error text label
                    textBoxResult.Text = ""; // clears the textbox in case it has the result of a prior calculation
                }
                else if (D >= 0) // else if D is more than zero or bigger than zero
                {
                    if (D == 0) // if D is zero
                    {
                        x = -b / 2 * a; // assigns result of calculation to x
                        textBoxResult.Text = $"x = {x:F2}"; // write out result with decimals limited to two
                    }
                    else // we already checked if D is less than zero and if D is zero so we can just use 'else'
                    {
                        x1 = (-b - Math.Sqrt(D)) / 2 * a; // assgins result of calculation to x1
                        x2 = (-b + Math.Sqrt(D)) / 2 * a; // assgins result of calculation to x1
                        textBoxResult.Text = $"x1  =  {x1:F2}    |    x2  =  {x2:F2} "; // write out result with decimals limited to two
                    }
                }
            }

            // x1 = (-b + Math.Sqrt(D)) / (2 * a);
            // x2 = (-b - Math.Sqrt(D)) / (2 * a);

            // if ( != )

        }
    }
}
