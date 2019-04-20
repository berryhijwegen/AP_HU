using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrixGenerator = new Matrix();
            int[,] matrix4_3 = matrixGenerator.generateMatrix(4, 3);
            int[,] matrix3_2 = matrixGenerator.generateMatrix(3, 2);
            
            for (int i = 0; i < matrix4_3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix4_3.GetLength(1); j++)
                {
                    Console.Write(matrix4_3[i,j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            for (int i = 0; i < matrix3_2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3_2.GetLength(1); j++)
                {
                    Console.Write(matrix3_2[i,j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            matrixGenerator.matrixMultiplication(matrix4_3, matrix3_2);
        }
    }
}
