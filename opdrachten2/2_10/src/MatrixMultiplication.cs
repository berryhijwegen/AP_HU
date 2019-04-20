using System;

namespace MatrixMultiplication
{
    class Matrix
    {
        public int[,] generateMatrix(int n, int m){
            int[,] matrix = new int[n,m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i,j] = rnd.Next(1,100);
                }
            }
            return matrix;
        }

        public void matrixMultiplication(int[,] matrixA, int[,] matrixB){
            if(matrixA.GetLength(1) == matrixB.GetLength(0)){
                int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixB.GetLength(1); j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < matrixA.GetLength(1); k++)
                        {
                                sum += matrixA[i,k] * matrixB[k,j];
                        }
                        resultMatrix[i,j] = sum;
                    }
                }

                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    {
                        Console.Write(resultMatrix[i,j] + " ");
                    }
                    Console.Write("\n");
                }
            }
            else {
                throw new System.ArgumentException("Matrices not multiplicateable");
            }
        }
    }
}
