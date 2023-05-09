﻿using System;
using System.Linq;
namespace MathLab2
{
    internal class Matrixes
    {
        //static void Main(string[] args)
        //{
        //    //float[,] matrixA ={
        //    //    { 3f, 5f, 1f,12f},
        //    //    { 1.799999f, 3f, 7f,13.599998f},
        //    //    { 8f,1f,1f,18f}};

        //    float[,] matrixA =
        //  {
        //       { 10f,4f,3f,4f,12f},
        //       {4f,12f,-4f,2f,1f },
        //       {2f,-1f,8f,1f,0f},
        //       {-1f,1f,3f,0f,4f }
        //   };
        //    //float[,] matrixB =
        //    //{
        //    //    {15f,0f,1f,16f },  
        //    //    {4f,15f,1f,20f },
        //    //    {1f,1f,15f,17f }
        //    //};
        //    //float[,] matrixB =
        //    //{
        //    //    { 10f,1f,2f,15f},
        //    //    {-3f,20f,4f,61f },
        //    //    {5f,6f,30f,53f}
        //    //};
        //    float[,] matrixB =
        //    {
        //       { 10f,4f,3f,12f},
        //       {4f,12f,-4f,1f },
        //       {2f,-1f,8f,0f}
        //   };

        //    float[,] matrixC =
        //    {
        //       {2f,-1f,0f,3f },
        //       {5f,4f,2f,6f },
        //       {0f,1f,-3f,2f }
        //   };


        //    //SolutionWithoutChooseOfMainElement(matrixA);
        //    SolutionWithChooseOfMainElement(matrixA);

        //    //Run_Through_Method(matrixC);
        //    //Console.WriteLine(matrixA.GetLength(0) + " " + matrixA.GetLength(1));
        //    //SpecialIterationsMethod(matrixB, 0.000001f); //-6
        //}
        public Matrixes() { }

        public void Run_Through_Method(float[,] matrix)
        {
            float[] a = new float[matrix.GetLength(1) + 1];
            float[] b = new float[matrix.GetLength(1) + 1];
            float[] solves = new float[matrix.GetLength(1) + 1];

            a[1] = matrix[0, 1] / matrix[0, 0];
            b[1] = matrix[0, matrix.GetLength(1) - 1] / matrix[0, 0];

            for (int i = 1; i < matrix.GetLength(0); i++)
            {

                a[i + 1] = matrix[i, i + 1] / (matrix[i, i] - matrix[i, i - 1] * a[i]);
                b[i + 1] = (matrix[i, matrix.GetLength(1) - 1] - b[i] * matrix[i, i - 1]) / (matrix[i, i] - matrix[i, i - 1] * a[i]);

                //matrix[i + 1, i + 1] = matrix[i + 1, i + 1] - matrix[i + 1, i] * a; 
                //matrix[i + 1, i] = 0;
            }
            for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
            {
                solves[i] = b[i + 1] - a[i + 1] * solves[i + 1];


            }
            Console.WriteLine();
            foreach (float i in solves)
            {
                Console.Write($" {i}");
            }
        }

        public float NormOfMatrix(float[,] matrix)
        {
            float[] tempNorms = new float[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    tempNorms[i] += Math.Abs(matrix[i, j]);
                }
            }
            return tempNorms.Max();
        }
        public void SpecialIterationsMethod(float[,] matrix, float e)
        {
            SpecialView(ref matrix);
            PrintMatrix(matrix);
            float normOfMatrix = NormOfMatrix(matrix);
            if (normOfMatrix >= 1)
            {
                Console.WriteLine("У матрицы не выполняется условие сходимости");
                return;
            }

            float[] actualVariablesX = new float[matrix.GetLength(0)];
            float[] tempVariablesX = new float[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                actualVariablesX[i] = matrix[i, matrix.GetLength(1) - 1];
            }
            int counter = 0;
            float maxDifference = float.MaxValue;
            do
            {

                actualVariablesX.CopyTo(tempVariablesX, 0);
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    actualVariablesX[i] = 0;
                    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                    {
                        actualVariablesX[i] += matrix[i, j] * tempVariablesX[j];
                    }
                    actualVariablesX[i] += matrix[i, matrix.GetLength(1) - 1];
                }


                for (int i = 0; i < actualVariablesX.Length; i++)
                {
                    if (normOfMatrix <= 0.5f)
                    {
                        if (Math.Abs(actualVariablesX[i] - tempVariablesX[i]) <= maxDifference)
                        {
                            maxDifference = Math.Abs(actualVariablesX[i] - tempVariablesX[i]);
                        }
                    }
                    else
                    {
                        if (Math.Abs(actualVariablesX[i] - tempVariablesX[i]) <= maxDifference)
                        {
                            maxDifference = (Math.Abs(actualVariablesX[i] - tempVariablesX[i]) * normOfMatrix) / (1f - normOfMatrix);
                        }
                    }
                }
                counter++;
                //Console.WriteLine("Iteration");
            }
            while (maxDifference > e);
            Console.WriteLine("Кол-во итераций: " + counter);
            for (int i = 0; i < actualVariablesX.Length; i++)
            {
                Console.Write(" " + actualVariablesX[i]);
            }

        }
        public void SpecialView(ref float[,] matrix)
        {
            float[,] newMatrix = new float[matrix.GetLength(0), matrix.GetLength(1)];
            float koef = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                koef = matrix[i, i];
                matrix[i, i] = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    else if (j == matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] /= koef;
                    }
                    else
                    {
                        matrix[i, j] /= -koef;
                    }
                }
            }
        }
        public float[,] TriangleView(float[,] matrix)
        {
            float koef = 0;
            for (int g = 0; g < matrix.GetLength(0) - 1; g++)
            {
                for (int i = 1 + g; i < matrix.GetLength(0); i++)
                {
                    koef = matrix[i, g] / -matrix[g, g];
                    for (int j = g; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = matrix[i, j] + matrix[g, j] * koef;
                    }
                }
            }
            return matrix;
        }
        public float[,] TriangleViewWithChooseOfMainElement(float[,] matrix)
        {
            float koef = 0;
            float temp = 0;
            bool flag = false;
            int index = 0;
            for (int g = 0; g < matrix.GetLength(0) - 1; g++)
            {
                temp = matrix[g, g];
                for (int h = g + 1; h < matrix.GetLength(0); h++)
                {
                    if (matrix[h, g] > temp)
                    {
                        temp = matrix[h, g];
                        index = h;
                        flag = true;
                    }

                }
                if (flag == true)
                {
                    for (int h = 0; h < matrix.GetLength(1); h++)
                    {
                        temp = matrix[g, h];
                        matrix[g, h] = matrix[index, h];
                        matrix[index, h] = temp;
                    }
                }



                for (int i = 1 + g; i < matrix.GetLength(0); i++)
                {

                    koef = matrix[i, g] / -matrix[g, g];
                    for (int j = g; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = matrix[i, j] + matrix[g, j] * koef;
                    }
                }
                flag = false;
            }
            return matrix;
        }
        public void PrintMatrix(float[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public float[] SolutionWithoutChooseOfMainElement(float[,] matrix)
        {
            matrix = TriangleView(matrix);
            PrintMatrix(matrix);
            return ReverseMove(matrix);

        }
        public float[] ReverseMove(float[,] matrix)
        {
            float[] allX = new float[matrix.GetLength(1)];
            float B = 0f;
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                B = matrix[i, matrix.GetLength(1) - 1];
                for (int j = i; j < matrix.GetLength(1); j++)
                {
                    B -= matrix[i, j] * allX[j];
                }
                allX[i] = B / matrix[i, i];
            }
            return allX;
        }
        public float[] SolutionWithChooseOfMainElement(float[,] matrix)
        {
            matrix = TriangleViewWithChooseOfMainElement(matrix);
            PrintMatrix(matrix);
            return ReverseMove(matrix);
        }
    }
}