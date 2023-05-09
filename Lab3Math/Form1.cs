using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double step = 0.1;
            double a = -6, b = 6;
            double x = 0, y = 0;
            double[] numsX = new double[] { -2, 0, 2, 3, 4 };
            double[] numsY = new double[] { 18, 12, 7, -1, 0 };
            int pow = 0;
            chart1.Series[0].Points.Clear();
            x = a;
            if (lagrangeButton.Checked )
            {
                Lagrange solver = new Lagrange(numsX,numsY);
                while (x <= b)
                {
                    pow = numsX.Length - 1;
                    y = The_Equation(pow, solver.GetCoefficients(), x);
                    chart1.Series[0].Points.AddXY(x, y);
                    x += step;
                }
            }
            if(newtonButton.Checked)
            {
                Newton solver = new Newton(numsX, numsY);
                while (x <= b)
                {
                    pow = numsX.Length - 1;
                    y = The_Equation(pow, solver.GetCoefficients(), x);
                    chart1.Series[0].Points.AddXY(x, y);
                    x += step;
                }
            }
            if (leastSquaresButton.Checked)
            {
                LesserSquares solver = new LesserSquares(numsX, numsY);
                while (x <= b)
                {
                  
                    pow = int.Parse(powTextBox.Text);
                    double[] coefficients = new double[pow+1];
                    solver.GetCoefficients(pow).CopyTo(coefficients, 0);
                    y = The_Equation(pow, coefficients, x);
                    chart1.Series[0].Points.AddXY(x, y);
                    x += step;
                }
            }
            if(EquationPow4.Checked)
            {
                while (x <= b)
                {
                    double[] coefficients = new double[5];
                    coefficients[0] = double.Parse(xPow4.Text);
                    coefficients[1] = double.Parse(xPow3.Text);
                    coefficients[2] = double.Parse(xPow2.Text);
                    coefficients[3] = double.Parse(xPow1.Text);
                    coefficients[4] = double.Parse(xPow0.Text);
                    y = The_Equation(4, coefficients, x);
                    chart1.Series[0].Points.AddXY(x, y);
                    x += step;
                }
            }
        }
        public double The_Equation(int pow, double[] coefficients,double x)
        {
            double y = 0;
            for(int i = 0;i<=pow;i++)
            {
                y += Math.Pow(x, i) * coefficients[pow - i];
            }
            return y;
        }
    }
}
