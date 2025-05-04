using System;

namespace Array2DConvertArray1D
{
   internal class Program
   {
      static void Main(string[] args)
      {
         // Creating a 2d Array with 2 rows and three columns
         int[,] int2DArray = new int[2, 3];
         Console.Write("Enter 2D Array Elements : ");
         for (int i = 0; i < 2; i++)
         {
            for (int j = 0; j < 3; j++)
            {
               int2DArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
         }
         int index = 0;
         //Getting the no of rows of 2d array 
         int noOfRows = int2DArray.GetLength(0);
         //Getting the no of columns of the 2d array
         int noOfColumns = int2DArray.GetLength(1);
         //Creating 1d Array by multiplying NoOfRows and NoOfColumns
         int[] oneDimensionalArray = new int[noOfRows * noOfColumns];

         //Assigning the elements to 1d Array from 2d array
         for (int y = 0; y < noOfColumns; y++)
         {
            for (int x = 0; x < noOfRows; x++)
            {
               oneDimensionalArray[index] = int2DArray[x, y];
               index++;
            }
         }
         //Printing the 1d array elements
         Console.WriteLine("1D Array Elements : ");
         foreach (int item in oneDimensionalArray)
         {
            Console.Write(item + " ");
         }

         //ArrayConvert();
         Console.ReadLine();
      }

      private static void ArrayConvert()
      {
         int row, column, i, j, k = 0;
         int[] array1D = new int[12];
         int[,] array2D = new int[12, 12];
         Console.WriteLine("Введите количество строк и столбцов");
         int.TryParse(Console.ReadLine(), out row);
         //row = Convert.ToInt32(Console.ReadLine());
         int.TryParse(Console.ReadLine(), out column);
         //column = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите элементы двумерного массива");
         for (i = 0; i < row; i++)
         {
            for (j = 0; j < column; j++)
            {
               int.TryParse(Console.ReadLine(), out array2D[i, j]);
               //array2D[i, j] = Convert.ToInt32(Console.ReadLine());
            }
         }

         Console.WriteLine("Двумерный массив:");
         for (i = 0; i < row; i++)
         {
            for (j = 0; j < column; j++)
            {
               //Console.WriteLine("[{0},{1}] = {2}", i, j, array2D[i, j]);
               Console.Write("[{0}]", array2D[i, j]);
            }

            Console.WriteLine();
         }

         Console.WriteLine("Одномерный массив:");
         for (i = 0; i < row; i++)
         {
            for (j = 0; j < column; j++)
            {
               array1D[k++] = array2D[i, j];
            }
         }

         for (i = 0; i < row * column; i++)
         {
            //Console.WriteLine("[{0}] = {1}", i, array1D[i]);
            Console.Write("[{0}]", array1D[i]);
         }
      }
   }
}