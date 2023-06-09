﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMathLab4;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            double step = 0.01;
            double a = -2, b = 1.5;
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
            if(SplineButton.Checked)
            {
                float[] numsFloatX = new float[] { -2, 0, 2, 3, 4 };
                //{ -2, 0, 2, 3, 4 };{ 0,1,2,3,4};
                float[] numsFloatY = new float[] { 18, 12, 7, -1, 0 };
                //{ 18, 12, 7, -1, 0 };{1,3,1,4,2 }; 
                CubeSpline solver = new CubeSpline(numsFloatX,numsFloatY);
                float[,] coefficients = solver.GetCoefficients();
                x = numsFloatX[0];
                b = numsFloatX[numsX.Length-1];
                int counter = 1;
                double[] tempCoefficients = new double[numsX.Length-1];
                for(int i = 0;i<coefficients.GetLength(1);i++)
                {
                    tempCoefficients[i] = coefficients[0,i];
                }
                while (x <= b)
                {
                    y = The_Equation(3, tempCoefficients, x);
                    chart1.Series[0].Points.AddXY(x, y);
                    x += step;
                    if (x >= numsFloatX[counter]&& counter<numsX.Length-1)
                    {
                        for (int i = 0; i < coefficients.GetLength(1); i++)
                        {
                            tempCoefficients[i] = coefficients[counter, i];
                        }
                        counter++;
                    }
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
