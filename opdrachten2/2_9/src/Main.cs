using System;

namespace Matrix
{
    class main
    {
        static void Main(string[] args)
        {
            // Generate random matrix
            Matrix matrixGenerator = new Matrix();
            int n = 4;
            int[,] matrix = matrixGenerator.generateMatrix(n);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int q = 0; q < matrix.GetLength(0); q++)
                {
                    Console.Write(matrix[i,q] + " ");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("");
            
            // Transpose Matrix
            int[,] TransposedMatrix = matrixGenerator.matrixTranspose(matrix);
            
            for (int i = 0; i < TransposedMatrix.GetLength(0); i++)
            {
                for (int q = 0; q < TransposedMatrix.GetLength(0); q++)
                {
                    Console.Write(TransposedMatrix[i,q] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
