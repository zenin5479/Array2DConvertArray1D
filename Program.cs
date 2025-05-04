using System;

namespace Array2DConvertArray1D
{
   internal class Program
   {
      static void Main(string[] args)
      {
         ArrayConvert();
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