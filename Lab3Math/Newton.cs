using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab3Math
{
    internal class Newton: Method
    {
        double[] x;
        double[] y;
        public Newton(double[] numsX, double[] numsY)
        {
            x = numsX;
            y = numsY;
        }
        public double[] GetCoefficients()
        {
            int length = x.Length;
            double[] coefficients = new double[length];
            coefficients[length - 1] += y[0];
            double temp = 0;
            double[,] tempCoefficients = new double[2, length];
            tempCoefficients[0, 0] = 1;
            tempCoefficients[0, 1] = -x[0];
            tempCoefficients[1, 0] = 1;
            tempCoefficients[1, 1] = -x[0];

            for (int k = 1; k < length; k++)
            {
                temp = Divided_Difference(k);
                if (k != 1)
                {
                    for (int i = 0; i < k; i++)
                    {
                        tempCoefficients[1, i] *= -x[k - 1];
                        tempCoefficients[0, i + 1] += tempCoefficients[1, i];
                    }

                    for (int i = 0; i <= k; i++)
                    {
                        coefficients[length - i - 1] += tempCoefficients[0, k - i] * temp;
                    }
                }
                else
                {
                    coefficients[length - 1] += tempCoefficients[0, 1] * temp;
                    coefficients[length - 2] += tempCoefficients[0, 0] * temp;
                }
                for (int i = 0; i < length; i++)
                {
                    tempCoefficients[1, i] = tempCoefficients[0, i];
                }
            }
            return coefficients;

        }
        public double Divided_Difference(int k)
        {
            double sum = 0;
            double temp = 1;
            for (int i = 0; i <= k; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    temp *= x[i] - x[j];
                }
                sum += y[i] / temp;
                temp = 1;
            }
            return sum;
        }
    }
}
