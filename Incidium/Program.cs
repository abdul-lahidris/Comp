using System;
using System.Linq;

namespace Vestigium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Vestigium!");

            int testCase;
            int matrixSize;

            Console.Write("Input number of test cases: ");
            testCase = int.Parse(Console.ReadLine());
            string[] caseResult = new string[testCase];

            for (int t = 1; t <= testCase; t++)
            {
                int trace = 0;
                int repeatRow = 0;
                int repeatColumn = 0;

                Console.Write("matrix size: ");
                matrixSize = int.Parse(Console.ReadLine());

                int[,] testMatrix = new int[matrixSize, matrixSize];
                int[] flatMatrix = new int[matrixSize];
                //populate flat matrix
                for (int f = 0; f < matrixSize; f++)
                {

                }

                Console.WriteLine("Enter matrix by row, seperate by space");
                for (int i = 0; i < matrixSize; i++)
                {

                    for (int j = 0; j < matrixSize; j++)
                    {
                        flatMatrix[i] = j + 1;
                    }
                }
                //trace
                for (int k = 0; k < matrixSize; k++)
                {
                    trace += testMatrix[k, k];
                }



                caseResult[t - 1] = string.Format("Case #{0}: {1} {2} {3}", t, trace, repeatRow, repeatColumn);
            }
            foreach (var item in caseResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
