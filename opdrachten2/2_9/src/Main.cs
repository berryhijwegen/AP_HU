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
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("");
            
            // Transpose Matrix
            int[,] z = matrixGenerator.matrixTranspose(matrix);
            
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(0); j++)
                {
                    Console.Write(z[i,j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
