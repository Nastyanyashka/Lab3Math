using MathLab2;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Math
{
    internal class LesserSquares
    {
        double[] x;
        double[] y;
        Matrixes matrixSolver = new Matrixes();
        public LesserSquares(double[] numsX, double[] numsY)
        {
            x = numsX;
            y = numsY;
        }
        public float[] GetCoefficients(int pow)
        {
            float[] coefficients = new float[pow + 1];
            float[] fakeCoefficients = new float[pow + 2];  
            float[,] matrix = new float[pow + 1, pow + 2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < x.Length; k++)
                    {
                        if (j != matrix.GetLength(1) - 1)
                        {
                            matrix[i, j] += (float)Math.Pow(x[k], (pow * 2) - j - i);
                        }
                        else
                        {
                            matrix[i, j] += (float)y[k] * (float)Math.Pow(x[k], (pow * 2) - j - i + 1);
                        }
                    }

                }
            }
            matrixSolver.SolutionWithChooseOfMainElement(matrix).CopyTo(fakeCoefficients, 0);
            for(int i = 0;i<=pow;i++)
            {
                coefficients[i] = fakeCoefficients[i];
            }
            return coefficients;
        }
    }
}
