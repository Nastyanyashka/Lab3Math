using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Resolvers;

namespace Lab3Math
{
    internal class Lagrange: Method
    {
        double[] x;
        double[] y;
        public Lagrange(double[] numsX, double[] numsY)
        {
            x = numsX;
            y = numsY;
        }
        public double[] GetCoefficients()
        {
            int length = x.Length;
            double[] coefficients = new double[length];
            double temp = 1;
            double[,] tempCoefficients = new double[2, length];
            double[] tempX = new double[length];
            int counter = 0;
            double kX = 0;
            for (int k = 0; k < length; k++)
            {
                for (int i = 0; i < length; i++)
                {
                    if (i == k)
                    {
                        kX = x[i];
                        continue;
                    }
                    tempX[counter] = x[i];
                    counter++;
                }
                counter = 0;
                tempCoefficients[0, 0] = 1;
                tempCoefficients[0, 1] = -tempX[0];
                tempCoefficients[1, 0] = 1;
                tempCoefficients[1, 1] = -tempX[0];
                for (int j = 2; j < length; j++)
                {

                    for (int i = 0; i < j; i++)
                    {
                        tempCoefficients[1, i] *= -tempX[j - 1];
                        tempCoefficients[0, i + 1] += tempCoefficients[1, i];
                    }

                    for (int i = 0; i < length; i++)
                    {
                        tempCoefficients[1, i] = tempCoefficients[0, i];
                    }
                }

                for (int i = 0; i < length - 1; i++)
                {
                    temp *= kX - tempX[i];
                }
                temp = y[k] / temp;
                for (int i = 0; i < length; i++)
                {
                    coefficients[i] += tempCoefficients[0, i] * temp;
                    tempCoefficients[0, i] = 0;
                    tempCoefficients[1, i] = 0;
                }
                temp = 1;

            }
            return coefficients;

        }
    }
}
