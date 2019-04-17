using System;

namespace Matrix
{
    class Matrix
    {
        public int[,] generateMatrix(int n){
            int[,] matrix = new int[n,n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int q = 0; q < n; q++)
                {
                    matrix[i,q] = rnd.Next(1,100);
                }
            }
            return matrix;
        }

        public int[,] matrixTranspose(int[,] matrix){
            int length = matrix.GetLength(0);
            int[,] transposedMatrix = new int[matrix.GetLength(0),matrix.GetLength(0)];

            for (int i = 0; i < length; i++)
            {
                for (int q = 0; q < length; q++)
                {
                    transposedMatrix[i,q] = matrix[q,i];
                }
            }
            return transposedMatrix;
        }
    }
}
