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
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = rnd.Next(1,100);
                }
            }
            return matrix;
        }

        public int[,] matrixTranspose(int[,] matrix){
            int length = matrix.GetLength(0);
            int temp = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0 + 1; j < length; j++)
                {
                    temp = matrix[i,j];
                    matrix[i,j] = matrix[j,i];
                    matrix[j,i] = temp;
                }
            }
            return matrix;
        }
    }
}
